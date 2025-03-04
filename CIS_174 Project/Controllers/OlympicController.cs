using CIS_174_Project.Models.Olympics;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CIS_174_Project.Controllers
{
    public class OlympicController : Controller
    {
        private CountryContext context;

        public OlympicController(CountryContext ctx)
        {
            context = ctx;
        }

        public ViewResult Countries(string activeSportType = "all", string activeGameType = "all")
        {
            ViewBag.ActiveSportType = activeSportType;
            ViewBag.ActiveGameType = activeGameType;

            ViewBag.SportTypes = context.SportTypes.ToList();
            ViewBag.GameTypes = context.GameTypes.ToList();

            IQueryable<Country> query = context.Countries.OrderBy(t => t.Name);

            if (activeSportType != "all")
                query = query.Where(t => t.SportType.SportTypeID.ToLower() == activeSportType.ToLower());

            if (activeGameType != "all")
                query = query.Where(t => t.GameType.GameTypeID.ToLower() == activeGameType.ToLower());

            var countries = query.ToList();

            return View(countries);
        }
    }
}

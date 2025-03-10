using CIS_174_Project.Models.Olympics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public ViewResult Countries(CountriesViewModel model)
        {
            var session = new OlympicSession(HttpContext.Session);
            session.SetActiveSport(model.ActiveSportType);
            session.SetActiveGame(model.ActiveGameType);

            model.SportTypes = context.SportTypes.ToList();
            model.GameTypes = context.GameTypes.ToList();

            IQueryable<Country> query = context.Countries.OrderBy(t => t.Name);

            if (model.ActiveSportType != "all")
                query = query.Where(t => t.SportType.SportTypeID.ToLower() == model.ActiveSportType.ToLower());

            if (model.ActiveGameType != "all")
                query = query.Where(t => t.GameType.GameTypeID.ToLower() == model.ActiveGameType.ToLower());

            model.Countries = query.ToList();

            return View(model);
        }

        public IActionResult Details(string id)
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountriesViewModel
            {
                Country = context.Countries.Include(t => t.SportType).Include(t => t.GameType).FirstOrDefault(t => t.CountryID == id) ?? new Country(),
                ActiveSportType = session.GetActiveSport(),
                ActiveGameType = session.GetActiveGame()
            };
            return View(model);
        }
    }
}

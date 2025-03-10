using CIS_174_Project.Models.Olympics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace CIS_174_Project.Controllers
{
    public class FavoritesController : Controller
    {
        private CountryContext context;
        public FavoritesController(CountryContext ctx) => context = ctx;

        [HttpGet]
        public ViewResult Index()
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountriesViewModel
            {
                ActiveSportType = session.GetActiveSport(),
                ActiveGameType = session.GetActiveGame(),
                Countries = session.GetMyCountries()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(Country country)
        {
            country = context.Countries.Include(t => t.SportType).Include(t => t.GameType).Where(t => t.CountryID == country.CountryID).FirstOrDefault() ?? new Country();

            var session = new OlympicSession(HttpContext.Session);
            var countries = session.GetMyCountries();
            countries.Add(country);
            session.SetMyCountries(countries);

            TempData["message"] = $"{country.Name} added to your favorites";

            return RedirectToAction("Countries", "Olympic", new {ActiveSportType = session.GetActiveSport(), ActiveGameType = session.GetActiveGame()});
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new OlympicSession(HttpContext.Session);
            session.RemoveMyCountries();

            TempData["message"] = "Favorite teams cleared";

            return RedirectToAction("Countries", "Olympic", new { ActiveSportType = session.GetActiveSport(), ActiveGameType = session.GetActiveGame() });
        }
    }
}

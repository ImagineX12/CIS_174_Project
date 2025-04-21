using Microsoft.AspNetCore.Mvc;

namespace CIS_174_Project.ViewComponents
{
    public class StatusButtonViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string statusId, int id)
        {
            if (statusId.ToLower() == "done")
            {
                return Content(string.Empty);
            }

            ViewBag.StatusId = statusId;
            ViewBag.Id = id;
            return View("Default");
        }
    }
}

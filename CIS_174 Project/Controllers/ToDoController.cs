using CIS_174_Project.Models.ToDoList;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CIS_174_Project.Controllers
{
    public class ToDoController : Controller
    {
        private ToDoContext context;
        public ToDoController(ToDoContext ctx) => context = ctx;

        public IActionResult Index(string id)
        {
            string filter = id ?? "all";


            ViewBag.Filter = id;
            ViewBag.Statuses = context.Statuses.ToList();

            IQueryable<ToDo> query = context.ToDos.Include(t => t.Status);
            if (filter != "all")
            {
                query = query.Where(t => t.StatusId == filter);
            }

            var tasks = query.OrderBy(t => t.SprintNumber).ToList();
            return View(tasks);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Statuses = context.Statuses.ToList();
            var task = new ToDo { StatusId = "open" };
            return View(task);
        }

        [HttpPost]
        public IActionResult Add(ToDo task)
        {
            if (ModelState.IsValid)
            {
                context.ToDos.Add(task);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Statuses = context.Statuses.ToList();
                return View(task);
            }
        }

        [HttpPost]
        public IActionResult Filter(string filter)
        {
            return RedirectToAction("Index", new { ID = filter });
        }

        [HttpPost]
        public IActionResult MarkComplete([FromRoute] string id, ToDo selected)
        {
            selected = context.ToDos.Find(selected.Id);
            if (selected != null)
            {
                if (selected.StatusId == "todo")
                {
                    selected.StatusId = "inprogress";
                    context.SaveChanges();
                }
                else if (selected.StatusId == "inprogress")
                {
                    selected.StatusId = "qa";
                    context.SaveChanges();
                }
                else if (selected.StatusId == "qa")
                {
                    selected.StatusId = "done";
                    context.SaveChanges();
                }
            }

            return RedirectToAction("Index", new { ID = id});
        }

        [HttpPost]
        public IActionResult DeleteComplete(string id)
        {
            var toDelete = context.ToDos.Where(t => t.StatusId == "done").ToList();

            foreach (var task in toDelete)
            {
                context.ToDos.Remove(task);
            }
            context.SaveChanges();

            return RedirectToAction("Index", new { ID = id });
        }
    }
}

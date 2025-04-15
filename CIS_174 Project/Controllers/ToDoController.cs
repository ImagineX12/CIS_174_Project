﻿using CIS_174_Project.Models.ToDoList;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using CIS_174_Project.Services;

namespace CIS_174_Project.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IRepository<ToDo> _toDoRepo;
        private readonly IRepository<Status> _statusRepo;

        public ToDoController(IRepository<ToDo> toDoRepo, IRepository<Status> statusRepo)
        {
            _toDoRepo = toDoRepo;
            _statusRepo = statusRepo;
        }

        public IActionResult Index(string id)
        {
            string filter = id ?? "all";


            ViewBag.Filter = id;
            ViewBag.Statuses = _statusRepo.List.ToList();

            IQueryable<ToDo> query = _toDoRepo.List.Include(t => t.Status);
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
            ViewBag.Statuses = _statusRepo.List.ToList();
            var task = new ToDo { StatusId = "open" };
            return View(task);
        }

        [HttpPost]
        public IActionResult Add(ToDo task)
        {
            if (ModelState.IsValid)
            {
                _toDoRepo.Insert(task);
                _toDoRepo.Save();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Statuses = _statusRepo.List.ToList();
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
            var existingTask = _toDoRepo.List.FirstOrDefault(t => t.Id == selected.Id);

            if (existingTask != null)
            {
                if (existingTask.StatusId == "todo")
                {
                    existingTask.StatusId = "inprogress";
                }
                else if (existingTask.StatusId == "inprogress")
                {
                    existingTask.StatusId = "qa";
                }
                else if (existingTask.StatusId == "qa")
                {
                    existingTask.StatusId = "done";
                }

                _toDoRepo.Save();
            }

            return RedirectToAction("Index", new { ID = id });
        }

        [HttpPost]
        public IActionResult DeleteComplete(string id)
        {
            var toDelete = _toDoRepo.List.Where(t => t.StatusId == "done").ToList();

            foreach (var task in toDelete)
            {
                _toDoRepo.Delete(task);
            }
            _toDoRepo.Save();

            return RedirectToAction("Index", new { ID = id });
        }
    }
}

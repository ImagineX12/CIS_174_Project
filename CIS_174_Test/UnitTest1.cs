using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using CIS_174_Project.Controllers;
using CIS_174_Project.Models;
using CIS_174_Project.Models.ToDoList;
using Moq;
using CIS_174_Project.Services;


namespace CIS_174_Test
{
    public class UnitTest1
    {
        //Returns Data for the test
        private List<Status> GetFakeStatuses() => new List<Status>
        {
            new Status { StatusId = "todo", Name = "To Do" },
            new Status { StatusId = "inprogress", Name = "In Progress" },
            new Status { StatusId = "qa", Name = "QA" },
            new Status { StatusId = "done", Name = "Done" },
        };
        private List<ToDo> GetFakeToDos() => new List<ToDo>
        {
            new ToDo { Id = 1, Description = "Test Task 1", SprintNumber = 1, StatusId = "todo" },
            new ToDo { Id = 2, Description = "Test Task 2", SprintNumber = 2, StatusId = "done" }
        };

        //Tests

        [Fact]
        public void Add_Get_ReturnsViewWithDefaultStatus()
        {
            var mockStatusRepo = new Mock<IRepository<Status>>();
            mockStatusRepo.Setup(r => r.List).Returns(GetFakeStatuses().AsQueryable());

            var mockToDoRepo = new Mock<IRepository<ToDo>>();
            var controller = new ToDoController(mockToDoRepo.Object, mockStatusRepo.Object);

            var result = controller.Add() as ViewResult;

            Assert.NotNull(result);
            var model = result.Model as ToDo;
            Assert.Equal("open", model.StatusId);
            Assert.Equal(4, ((List<Status>)controller.ViewBag.Statuses).Count);
        }

        [Fact]
        public void Add_Post_ValidModel_RedirectsToIndex()
        {
            var mockToDoRepo = new Mock<IRepository<ToDo>>();
            var mockStatusRepo = new Mock<IRepository<Status>>();

            var controller = new ToDoController(mockToDoRepo.Object, mockStatusRepo.Object);
            var task = new ToDo { Id = 3, Description = "New Task", StatusId = "todo" };

            var result = controller.Add(task) as RedirectToActionResult;

            mockToDoRepo.Verify(r => r.Insert(task), Times.Once);
            mockToDoRepo.Verify(r => r.Save(), Times.Once);
            Assert.Equal("Index", result.ActionName);
        }

        [Fact]
        public void MarkComplete_UpdatesStatusAndSaves()
        {
            var mockToDoRepo = new Mock<IRepository<ToDo>>();
            var mockStatusRepo = new Mock<IRepository<Status>>();

            var todoList = GetFakeToDos().AsQueryable();
            mockToDoRepo.Setup(r => r.List).Returns(todoList);

            var controller = new ToDoController(mockToDoRepo.Object, mockStatusRepo.Object);

            var result = controller.MarkComplete("todo", new ToDo { Id = 1 }) as RedirectToActionResult;

            Assert.Equal("Index", result.ActionName);
            Assert.Equal("todo", result.RouteValues["ID"]);
            mockToDoRepo.Verify(r => r.Save(), Times.Once);
        }

        [Fact]
        public void DeleteComplete_RemovesDoneTasks()
        {
            var toDos = GetFakeToDos();
            var mockToDoRepo = new Mock<IRepository<ToDo>>();
            var mockStatusRepo = new Mock<IRepository<Status>>();

            mockToDoRepo.Setup(r => r.List).Returns(toDos.AsQueryable());

            var controller = new ToDoController(mockToDoRepo.Object, mockStatusRepo.Object);

            var result = controller.DeleteComplete("done") as RedirectToActionResult;

            mockToDoRepo.Verify(r => r.Delete(It.Is<ToDo>(t => t.StatusId == "done")), Times.Exactly(1));
            mockToDoRepo.Verify(r => r.Save(), Times.Once);
            Assert.Equal("done", result.RouteValues["ID"]);
        }

        [Fact]
        public void Filter_Post_RedirectsToIndexWithFilter()
        {
            var mockToDoRepo = new Mock<IRepository<ToDo>>();
            var mockStatusRepo = new Mock<IRepository<Status>>();

            var controller = new ToDoController(mockToDoRepo.Object, mockStatusRepo.Object);
            var result = controller.Filter("qa") as RedirectToActionResult;

            Assert.Equal("Index", result.ActionName);
            Assert.Equal("qa", result.RouteValues["ID"]);
        }
    }
}
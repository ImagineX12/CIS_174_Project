using Microsoft.AspNetCore.Mvc;
using CIS_174_Project.Models;

namespace CIS_174_Project.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentList(int id = 1)
        {
            if (id < 1) id = 1;
            if (id > 10) id = 10;

            List<StudentModel> students = new List<StudentModel>
            {
                new StudentModel("Zack", "Newman", 95),
                new StudentModel("Alexander", "Cline", 84),
                new StudentModel("Christopher", "Richter", 79)
            };

            var viewModel = new StudentViewModel(students, id);

            return View(viewModel);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using HW221212.Data;
using HW221212.Models;
using System.Collections.Generic;


namespace HW221212.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentData db = new StudentData();
            var students = db.GetStudents();
            return View(students);
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(int value1)
        {
            StudentData db = new StudentData();
            var student = db.SearchStudent(value1);
            return View(student);
        }
    }
}

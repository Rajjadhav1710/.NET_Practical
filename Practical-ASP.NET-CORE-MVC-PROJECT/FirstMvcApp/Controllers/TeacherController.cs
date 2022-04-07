using FirstMvcApp;
using FirstMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FirstMvcApp.Controllers{
    public class TeacherController : Controller{
         private readonly ApplicationDBContext _db;

         public TeacherController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Teacher> listofteachers = _db.Teacher;
            return View(listofteachers);
        }

        private void PopulateTeachersDropDownList (object selectedTeacher = null )
        {
            var teachersQuery = from s in _db.Teacher
                                orderby s.Teacher_Name
                                select new {TeacherId = s.ID, s.Teacher_Name};

           ViewBag.TeacherId = new SelectList(teachersQuery.AsNoTracking(),"TeacherId","Teacher_Name",selectedTeacher);

        }
        
        //Get Create
        public IActionResult Create()
        {
            PopulateTeachersDropDownList(); 
            return View();
        }
    }
}
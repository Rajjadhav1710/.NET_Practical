using FirstMvcApp;
using FirstMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMvcApp.Controllers{
    public class SubjectController : Controller{
        private readonly ApplicationDBContext _db;

        public SubjectController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index(string searchtext)
        {
            IEnumerable<Subject> listofsubjects = _db.Subject;

            if(!String.IsNullOrEmpty(searchtext))
            {
               listofsubjects= listofsubjects.Where(s=> s.Subject_Name.Contains(searchtext));
            }
            return View(listofsubjects);
        }

        //create

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("syllabus,Subject_Name,credits")] Subject subobj)
        {
            if (ModelState.IsValid)
            {
                _db.Subject.Add(subobj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subobj);
        }

        //edit
        [HttpGet]
        public IActionResult Edit(int subjectid)
        {
            var subobj = _db.Subject.Find(subjectid);
            return View(subobj);

        }

        [HttpPost]
        public IActionResult Edit(Subject updatedvaluesobj)
        {
            _db.Subject.Update(updatedvaluesobj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        
        [HttpGet]
        public IActionResult Delete(int subjectid)
        {

            var subobj = _db.Subject.Find(subjectid);

            if(subobj!=null){
                _db.Subject.Remove(subobj);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
            // return View(studobj);
        }

    }
}
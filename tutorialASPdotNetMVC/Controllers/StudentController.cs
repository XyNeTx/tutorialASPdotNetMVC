using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using tutorialASPdotNetMVC.Data;
using tutorialASPdotNetMVC.Models;

namespace tutorialASPdotNetMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDBContext _db;
        public StudentController (ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            // return Content("StudentControllerIndex");
            // return Json(new { studentId = 1 });

            IEnumerable <Student> studentLists = _db.Students;

            return View(studentLists);
        }
        // GET Method
        public IActionResult Create()
        {
            //return Content("รายละเอียดคะแนนสอบ");
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student obj) 
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Students.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        /*public IActionResult ShowScore(int id) {
            return Content($"คะแนนสอบของไอดี {id}");
        }*/
    }
}

using System.Collections.Generic;
using e_shopping.Data;
using e_shopping.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_shopping.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;
        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult ctrg()
        {
            IEnumerable<Categories> objCategory = _db.categories;

            return View(objCategory);
        }
        [HttpGet]
        public IActionResult AddNew()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNew(Categories cate)
        {
           if(ModelState.IsValid)
            {
                _db.categories.Add(cate);
                _db.SaveChanges();
                return RedirectToAction("ctrg");
            }
           return View();
        }
        [HttpGet]
         public IActionResult edit(int id)
        {
            var edt =_db.categories.Find(id);
            _db.SaveChanges();
            return View(edt);
        }
        [HttpPost]
        public IActionResult edit(Categories cate)
        {
           if(ModelState.IsValid)
            {
                _db.categories.Update(cate);
                _db.SaveChanges();
                return RedirectToAction("ctrg");
            }
           return View();
        }
        
    }
}
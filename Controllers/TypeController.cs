using System.Collections.Generic;
using System.Linq;
using e_shopping.Data;
using e_shopping.Models;
using Microsoft.AspNetCore.Mvc;


namespace e_shopping.Controllers
{
    public class TypeController : Controller
    {
        
         private readonly ApplicationDBContext _db;

        public TypeController(ApplicationDBContext database) 
        {
            _db = database;
        }
        public IActionResult Types()
        {

             IEnumerable<Type> objtype = _db.types;

            return View(objtype);
        }
        [HttpGet]
        public IActionResult EditType(int ID)
        {
            var edtType = _db.types.Find(ID);
            _db.SaveChanges(); 
            return View(edtType);
        }
        [HttpPost]
        public IActionResult EditType(Type tp)
        {
            if(ModelState.IsValid)
            {
                _db.types.Update(tp);
            _db.SaveChanges();
            return RedirectToAction("Types");
            }
            return View();
        }
         [HttpGet]
        public IActionResult addtypes()
        {
            return View();
        }
         [HttpPost]
        public IActionResult addtypes (Type tp)
        {
            if(ModelState.IsValid)
            {
                _db.types.Add(tp);
            _db.SaveChanges();
            return RedirectToAction("Types");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
             var del = _db.types.Find(id);
            _db.SaveChanges(); 
            return View(del);
        }
        [HttpPost]
        public IActionResult Delete(Type typeID)
        {
           if(ModelState.IsValid)
           {
              var del= _db.types.Remove(typeID);
                _db.SaveChanges();
                return RedirectToAction("Types");
           }
           

             return View();
        }
    
    }  
}
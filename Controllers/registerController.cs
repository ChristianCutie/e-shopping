using System;
using System.Collections.Generic;
using e_shopping.Data;
using e_shopping.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_shopping.Controllers
{
    public class registerController : Controller
    {
        private readonly ApplicationDBContext _db;

        public registerController(ApplicationDBContext dt)
        {
            _db = dt;
        }
        [HttpGet]
        public IActionResult registeracc()
        {
            IEnumerable<register> objreg = _db.registers;
            return View();
        }
        [HttpPost]
        public IActionResult registeracc(register regi)
        {   
            _db.registers.Add(regi);
            _db.SaveChanges();
            return RedirectToAction("login");
        }
                
    }
}
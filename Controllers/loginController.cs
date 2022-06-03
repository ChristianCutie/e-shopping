using System;
using System.Linq;
using e_shopping.Data;
using e_shopping.Models;
using Microsoft.AspNetCore.Mvc;



namespace e_shopping.Controllers
{
    public class loginController : Controller
    {
        private readonly ApplicationDBContext _db;
       

        public loginController (ApplicationDBContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult login(login log)
        {
             if(ModelState.IsValid)
             {
                  //Validating the user, whether the user is valid or not.
                 var valid = IsValidUser(log);

               if(valid != null)
               {
                   return RedirectToAction("Index", "Home");
               }
               else
               {
                   ModelState.AddModelError("Failure", "Wrong Username and password combination !");
                    return View();
               }
             } 
             else
             {
                 return View(log);
             }            
        }
        public login IsValidUser(login lg)
        {
          login lgn = _db.logins.Where(a => a.Username.Equals(lg.Username) && 
          a.Password.Equals(lg.Password)).SingleOrDefault();
         if (lgn == null)
                    return null;
                //If user is not present false is returned.
                else
                    return lgn;
        }

    }
}
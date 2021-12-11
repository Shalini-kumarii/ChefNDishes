using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Chef_N_Dishes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Http;  //This is where session comes from
namespace Chef_N_Dishes.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        private MyContext _context;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("")]      // Both lines can be written in one line
        public ViewResult Index()
        {
            List<Chef> AllChef = _context.Chefs
                .Include(d => d.DishList)
                .ToList();


            return View("Index", AllChef);
        }
        [HttpGet("/chef")]      // Both lines can be written in one line
        public ViewResult ChefInfo()
        {
            List<Chef> AllChef = _context.Chefs
                .Include(d => d.DishList)
                .ToList();


            return View("Index", AllChef);
        }

        [HttpGet("dishes")]

        public IActionResult DishesInfo()
        {
            List<Chef> AllChefList = _context.Chefs
               .Include(d => d.DishList)
               .ToList();


            return View("DishesInfo", AllChefList);
        }

        [HttpGet("NewDish")]
        public IActionResult Dish()
        {
            List<Chef> AllChef = _context.Chefs
               .ToList();
            ViewBag.AllchefList = AllChef;
            return View("Dish");
        }
        [HttpGet("/home")]

        public IActionResult GoBackHome()
        {
            return RedirectToAction("Index");
        }



        [HttpPost("dish/newdish")]
        public IActionResult NewDish(Dish fromForm)
        {
            if (ModelState.IsValid)
            {

                _context.Add(fromForm);
                _context.SaveChanges();
                return RedirectToAction("Index", new { dishId = fromForm.DishId });
            }
            else
            {
                return View("Dish");
            }
        }

        [HttpGet("NewChef")]
        public IActionResult Chef()
        {
            return View("Chef");
        }

        [HttpPost("dish/newChef")]
        public IActionResult NewChef(Chef fromForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fromForm);
                _context.SaveChanges();
                return RedirectToAction("Index", new { ChefId = fromForm.ChefId });
            }
            else
            {
                return View("Chef");
            }
        }

    }
}








using Restaurant_Rater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Rater.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantDbContext _context = new RestaurantDbContext();

        // GET: Restaurant/Index
        public ActionResult Index()
        {
            return View(_context.Restaurants.ToList());
        }

        //Get: Restaurant/Create
        public ActionResult Create()
        {
            return View();
        }

        //Post: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _context.Restaurants.Add(restaurant);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(restaurant);
        }
    }
}
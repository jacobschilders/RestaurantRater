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
    }
}
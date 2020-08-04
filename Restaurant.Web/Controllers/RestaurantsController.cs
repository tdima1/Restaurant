using RestaurantChain.Data.Models;
using RestaurantChain.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantChain.Web.Controllers
{
   public class RestaurantsController : Controller
   {
      private readonly IRestaurantData db;

      public RestaurantsController(IRestaurantData db)
      {
         this.db = db;
      }

      // GET: Restaurants
      public ActionResult Index()
      {
         var model = db.GetAllRestaurants();
         return View(model);
      }

      public ActionResult Details(int id)
      {
         var model = db.GetRestaurantForId(id);
         if (model == null) {
            return View("NotFound");
         }
         return View(model);
      }
      
      [HttpGet]
      public ActionResult Create()
      {
         return View();
      }

      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Create(Restaurant restaurant)
      {
         if(ModelState.IsValid) {
            db.AddRestaurant(restaurant);
            return RedirectToAction("Details", new { id = restaurant.Id });
         }
         return View();
      }

      [HttpGet]
      public ActionResult Edit(int id)
      {
         var model = db.GetRestaurantForId(id);
         if (model != null) {
            return View(model);
         }
         return HttpNotFound();
      }

      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Edit(Restaurant restaurant)
      {
         if(ModelState.IsValid) {
            db.EditRestaurant(restaurant);
            return RedirectToAction("Details", new { id = restaurant.Id });
         }
         return View(restaurant);
      }

      [HttpGet]
      public ActionResult Delete(int id)
      {
         var model = db.GetRestaurantForId(id);
         if (model != null) {
            return View(model);
         }
         return HttpNotFound();
      }

      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Delete(int id, FormCollection collection)
      {
         db.Delete(id);
         return RedirectToAction("Index");
      }
   }
}
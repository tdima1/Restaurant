﻿using RestaurantChain.Data.Services;
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
   }
}
using RestaurantChain.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantChain.Web.Controllers
{
   public class GreetingController : Controller
   {
      // GET: Greeting
      public ActionResult Index()
      {
         var model = new GreetingViewModel();
         model.Message = ConfigurationManager.AppSettings["message"];
         return View(model);
      }
   }
}
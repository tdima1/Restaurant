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
      public ActionResult Index(string name)
      {
         var model = new GreetingModel();

         model.Message = ConfigurationManager.AppSettings["message"];
         model.Name = name ?? "no name";
         return View(model);
      }
   }
}
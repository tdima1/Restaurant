using RestaurantChain.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantChain.Web.Models
{
   public class GreetingViewModel
   {
      public string Name { get; set; }
      public string Message { get; set; }
      public IEnumerable<Restaurant> Restaurants { get; set; }
   }
}
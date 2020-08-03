using RestaurantChain.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestaurantChain.Data.Models;

namespace RestaurantChain.Web.API
{
   public class RestaurantsController : ApiController
   {
      private readonly IRestaurantData db;

      public RestaurantsController(IRestaurantData db)
      {
         this.db = db;
      }
      public IEnumerable<Restaurant> Get()
      {
         var model = db.GetAllRestaurants();
         return model;
      }
   }
}

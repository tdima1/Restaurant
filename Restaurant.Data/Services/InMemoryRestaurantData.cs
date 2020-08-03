﻿using RestaurantChain.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantChain.Data.Services
{

   public class InMemoryRestaurantData : IRestaurantData
   {
      private List<Restaurant> restaurants;

      public InMemoryRestaurantData()
      {
         restaurants = new List<Restaurant>() {
            new Restaurant{Id = 1, Name = "Pizza Joint", Cuisine = eCuisineType.Italian},
            new Restaurant{Id = 2, Name = "Curry Restaurant", Cuisine = eCuisineType.Indian},
            new Restaurant{Id = 3, Name = "Snails Restaurant", Cuisine = eCuisineType.French}
         };
      }

      public IEnumerable<Restaurant> GetAllRestaurants()
      {
         return restaurants.OrderBy(r => r.Name);
      }
   }
}
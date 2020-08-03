using RestaurantChain.Data.Models;
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

      public void AddRestaurant(Restaurant restaurant)
      {
         restaurant.Id = restaurants.Max(r => r.Id) + 1;
         restaurants.Add(restaurant);
      }

      public IEnumerable<Restaurant> GetAllRestaurants()
      {
         return restaurants.OrderBy(r => r.Name);
      }

      public Restaurant GetRestaurantForId(int id)
      {
         return restaurants.FirstOrDefault(r => r.Id.Equals(id));
      }
   }
}

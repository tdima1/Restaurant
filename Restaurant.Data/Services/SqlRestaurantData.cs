using RestaurantChain.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantChain.Data.Services
{
   public class SqlRestaurantData : IRestaurantData
   {
      private readonly RestaurantsChainDbContext db;

      public SqlRestaurantData(RestaurantsChainDbContext db)
      {
         this.db = db;
      }

      public void AddRestaurant(Restaurant restaurant)
      {
         db.Restaurants.Add(restaurant);
         db.SaveChanges();
      }

      public void Delete(int id)
      {
         var restaurant = db.Restaurants.Find(id);
         db.Restaurants.Remove(restaurant);
         db.SaveChanges();
      }

      public void EditRestaurant(Restaurant newRestaurant)
      {
         var entry = db.Entry(newRestaurant);
         entry.State = EntityState.Modified;
         db.SaveChanges();
      }

      public IEnumerable<Restaurant> GetAllRestaurants()
      {
         return from r in db.Restaurants
                orderby r.Name
                select r;
      }

      public Restaurant GetRestaurantForId(int id)
      {
         return db.Restaurants.FirstOrDefault(r => r.Id == id);
      }
   }
}

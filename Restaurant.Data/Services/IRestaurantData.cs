using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantChain.Data.Models;

namespace RestaurantChain.Data.Services
{
   public interface IRestaurantData
   {
      IEnumerable<Restaurant> GetAllRestaurants();
      Restaurant GetRestaurantForId(int id);

   }
}

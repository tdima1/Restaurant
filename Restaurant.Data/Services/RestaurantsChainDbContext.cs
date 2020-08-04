using RestaurantChain.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantChain.Data.Services
{
   public class RestaurantsChainDbContext : DbContext
   {
      public DbSet<Restaurant> Restaurants { get; set; }
   }
}

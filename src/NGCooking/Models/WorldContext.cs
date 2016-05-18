using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace NGCooking.Models
{
    public class WorldContext : DbContext 
    {
        public DbSet<Recette> Recettes { get; set; }
        public DbSet<User> Users { get; set; }
      
    }
}

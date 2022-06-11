using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary.Models;

namespace StoreLibrary.Database
{
    class StorLibDbContext:DbContext 
    {
        public StorLibDbContext():base("naem=DefaultConnection")
        {

        }
        public DbSet<User> USers { get; set; }
        public DbSet<Item> Items{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

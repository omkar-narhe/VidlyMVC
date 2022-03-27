using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly5.Models
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Genre> Genre { get; set; }

        public ApplicationDbContext()
        {
        }   
        
    }
}
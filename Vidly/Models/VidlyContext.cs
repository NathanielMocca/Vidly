using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Vidly.Models
{
    public class VidlyContext : DbContext
    {
        public VidlyContext()

        {

        }

        //Entities

        public DbSet<Customers> Customers { get; set; }

        public DbSet<Movie> Movies { get; set; }

    
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 
namespace WebApplication1.DatabaseContext
{
    public class Context: DbContext
    {
        public DbSet<Models.Movie> Movies { get; set; }
    }
}
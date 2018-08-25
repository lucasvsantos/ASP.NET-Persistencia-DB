using _06.FIAP.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _06.FIAP.Web.MVC.Persistencia
{
    public class BotecoContext : DbContext
    {
        public DbSet<Bebida> Bebidas { get; set; }
        public DbSet<Petisco> Petiscos { get; set; }

    }
}
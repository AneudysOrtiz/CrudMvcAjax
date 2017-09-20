using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class GeneralContext :DbContext
    {
        public GeneralContext() :base("name=MyDB"){ }

        public virtual DbSet<Clientes> Clientes { get; set; }
    }
}
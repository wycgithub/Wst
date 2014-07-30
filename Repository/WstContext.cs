using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Wst.Model;

namespace Wst.Repository
{
    public class WstContext:DbContext
    {
      static WstContext()
        {
            Database.SetInitializer<WstContext>(null);
        }

      public WstContext()
          : base("Name=WSTContext")
        {
        }
      public DbSet<Users> Users { get; set; }
    }
}
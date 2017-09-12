using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FineUIMvc.QuickStart.Models
{
    public class NewsTypeDbcontext: DbContext
    {
        public NewsTypeDbcontext(): base("DefaultConnection")
        {
        }

        public DbSet<NewsType> NewsTypes { get; set; }
    }
}
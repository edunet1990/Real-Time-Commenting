using Real_Time_Commenting.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Real_Time_Commenting.Context  
{
    public class ApplicaitonDbContext : DbContext
    {
        public ApplicaitonDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
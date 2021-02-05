using EvaluationApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationApp.DAL
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<UrlResponseStat> UrlResponseStats { get; set; }
        public DbSet<WebsiteUrl> WebsiteUrls { get; set; }
    }
}

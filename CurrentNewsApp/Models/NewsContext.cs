using CurrentNewsApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrentNewsApp.Models
{
    public class NewsContext : DbContext
    {
        public DbSet<News> newsSet;
        public IHttpWebRequestHandler handler;

        public NewsContext(DbContextOptions options, 
            IHttpWebRequestHandler handler) : base(options)
        {
            this.handler = handler;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            {
                modelBuilder.Entity<News>().HasData(new News().data = handler.GetNews("https://www.tvn24.pl/najnowsze.xml"));

            }
        }
    }
}

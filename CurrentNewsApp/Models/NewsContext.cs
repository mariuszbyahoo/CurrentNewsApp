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
        public DbSet<News> NewsSet { get; set; }
        public IHttpWebRequestHandler handler = new HttpWebRequestHandler();

        public NewsContext(DbContextOptions<NewsContext> options) : base(options)
        {
        }

        // Ta metoda nie funkcjonuje jak planowałem; context nie otrzymuje na rozruchu aplikacji nowego obiektu i przypisanych do niego danych.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().HasData(
                new News()
                {
                    Data = handler.GetNews("https://www.tvn24.pl/najnowsze.xml"),
                    Id = Guid.NewGuid()
                }
            );
        }
    }
}

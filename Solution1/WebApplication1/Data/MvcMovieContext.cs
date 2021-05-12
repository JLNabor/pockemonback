using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> dbContextOptions) : base(dbContextOptions) 
        { 

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie {Id=1, Genre="Horror", Price=12.2M, Title="perrin", ReleaseDate= DateTime.Today  },
                new Movie {Id = 2, Genre = "Humor", Price = 13.44M, Title = "perron", ReleaseDate = DateTime.Today }
                );
        }


    }
}

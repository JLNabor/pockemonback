using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTesting.Model;

namespace WebApiTesting.Data
{
    public class PockemonContext: DbContext
    {
        public PockemonContext(DbContextOptions<PockemonContext> options) : base(options)
        { 
        }

        public DbSet<Pockemo> Pockemos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Pockemo>().HasData(
                new Pockemo { Id = 1, Name="picahu Mexicano", Description="Picachu equis", Photo= "https://pbs.twimg.com/media/Eio96N9WAAEHuvI.jpg" },
                new Pockemo { Id = 2, Name = "Pelicano Mexicano", Description = "Pelicano equis", Photo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRZpaNtJffGe5VRveyp7akE-mPKOBelV5kkCQ&usqp=CAU" },
                new Pockemo { Id = 3, Name = "Perro Mexicano", Description = "Perro equis", Photo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTqTX3pGP591zsndXnabjeEyBQ6L_6m7Frp7w&usqp=CAU" });
        }

    }
}

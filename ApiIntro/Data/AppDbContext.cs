﻿using ApiIntro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace ApiIntro.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
                 new Category { 
                        Id = 1, 
                        CreatedDate = DateTime.Now, 
                        Name = "UI UX",
                 },
                 new Category
                 {
                     Id = 2,
                     CreatedDate = DateTime.Now,
                     Name = "Backend",
                 },
                 new Category
                 {
                     Id = 3,
                     CreatedDate = DateTime.Now,
                     Name = "Frontend",
                 }

              );

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    Name = "Isgendername",
                },
                new Book
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    Name = "Ali ve Nino",
                }

             );


            base.OnModelCreating(modelBuilder);
        }
    }
}

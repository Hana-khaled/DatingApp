using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Entities.AppUser> appUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser() { ID = 1, UserName = "Mark" },
                new AppUser() { ID = 2, UserName = "John"},
                new AppUser() { ID = 3, UserName = "Alex" }
                );
        }
    }

}
using BilgeOtel.Entity.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.DAL.Context
{
    public class ProjectContext : IdentityDbContext<AppUser, AppUserRole, int>
    {

        //todo: buraya bak
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
        }
        DbSet<Product> Products { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<Rental> Rentals { get; set; }
        DbSet<Room> Rooms { get; set; }
        DbSet<RentUser> RentUsers { get; set; }
        DbSet<Reservation> Reservations { get; set; }
        DbSet<Employee> Employees { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("server=DESKTOP-I2PPH77;database=BilgeOtelProject;uid=sa;pwd=123; TrustServerCertificate=true");
        //    }

        //    base.OnConfiguring(optionsBuilder);
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    base.OnModelCreating(modelBuilder);
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("server=DESKTOP-I2PPH77;database=BilgeOtelProject;uid=sa;pwd=123; TrustServerCertificate=true");
        //    }
        //    base.OnConfiguring(optionsBuilder);
        //}
    }

}

﻿using FFCProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FFCProject.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnectionString"));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OtpEntry> OtpEntries { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Attendance> Attendances { get; set; }

        public DbSet<Asset> Assets { get; set; }

        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<Vendor> Vendors { get; set; }





    }
}

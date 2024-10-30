﻿using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrate
{
    public class Context : IdentityDbContext<AppUser , AppRole , int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SSARIBAS130721\\SSARIBAS; initial catalog=HotelProjectDb ; integrated security=true");
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<About> Abouts { get; set; }
		public DbSet<Rezervation> Rezervations { get; set; }

	}
}

﻿using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

using KutuphaneSistemi.SystemData;
using KutuphaneSistemi.SystemData.Member;

using Microsoft.EntityFrameworkCore;

namespace KutuphaneSistemi.Database.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<SystemHistory> SystemHistory { get; set; }
        public DbSet<Rezervation> Rezervation { get; set; }
        public DbSet<NormalMember> NormalMember { get; set; }
        public DbSet<PersonelMember> PersonelMember { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=kutuphane;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True");
        }

    }

}

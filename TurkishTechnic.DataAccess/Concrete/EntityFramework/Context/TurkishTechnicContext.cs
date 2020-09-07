using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TurkishTechnic.Entities;

namespace TurkishTechnic.DataAccess.Concrete.EntityFramework.Context
{
    public class TurkishTechnicContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=WorkingTimes;Trusted_Connection=true");
        }

        public DbSet<WorkingTime> WorkingTimes { get; set; } 
    }
}

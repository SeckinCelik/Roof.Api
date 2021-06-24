using Microsoft.EntityFrameworkCore;
using Roof.Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roof.Core.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=ConnectionStrings:DefaultConnection");
            }
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
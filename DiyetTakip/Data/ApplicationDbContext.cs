using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DiyetTakip.Models;

namespace DiyetTakip.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DiyetTakip.Models.Day> Day { get; set; }
        public DbSet<DiyetTakip.Models.Food> Food { get; set; }
        public DbSet<DiyetTakip.Models.Category> Category { get; set; }
    }
}

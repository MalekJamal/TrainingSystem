using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingSystem.Core.Models;
using static System.Collections.Specialized.BitVector32;

namespace TrainingSystem.EF.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<Session> Sessions { get; set; }


        public DbSet<LookUp> Lookups { get; set; }

        public DbSet<LookUpCategory> LookupCategories { get; set; }

        public DbSet<User> Users { get; set; }
    }
}

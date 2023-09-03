using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrainingSystem.Core.Models;
using static System.Collections.Specialized.BitVector32;

namespace TrainingSystem.EF.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Session> Session { get; set; }
        public DbSet<Lookup> Lookup { get; set; }
        public DbSet<LookupCategory> LookupCategory { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define primary keys
            modelBuilder.Entity<Lookup>().HasKey(e => e.Id);
            modelBuilder.Entity<LookupCategory>().HasKey(e => e.CategoryId);

            // Your model configurations...

            // Seed data
            SeedData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Seed data for LookupCategories
            modelBuilder.Entity<LookupCategory>().HasData(
                new LookupCategory { CategoryId = 100, Code = 1, NameEn = "Training Type", NameAr = "نوع التدريب" },
                new LookupCategory { CategoryId = 200, Code = 2, NameEn = "Training Topics", NameAr = "موضوعات التدريب" },
                new LookupCategory { CategoryId = 300, Code = 3, NameEn = "Training Status", NameAr = "حالة التدريب" },
                new LookupCategory { CategoryId = 400, Code = 4, NameEn = "Training Result", NameAr = "نتيجة التدريب" }
            );

            // Seed data for Lookups using enum values
            modelBuilder.Entity<Lookup>().HasData(
                // Training Type Lookups
                new Lookup { Id = 1, Code = 1, NameEn = "Work", NameAr = "عمل", LookupCategoryId = 100 },
                new Lookup { Id = 2, Code = 2, NameEn = "University", NameAr = "جامعة", LookupCategoryId = 100 },

                // Training Topics Lookups
                new Lookup { Id = 3, Code = 1, NameEn = "DotNet", NameAr = ".Net", LookupCategoryId = 200 },
                new Lookup { Id = 4, Code = 2, NameEn = "BusinessAnalyst", NameAr = "محلل أعمال", LookupCategoryId = 200 },
                new Lookup { Id = 5, Code = 3, NameEn = "QualityControl", NameAr = "مراقبة الجودة", LookupCategoryId = 200 },
                new Lookup { Id = 6, Code = 4, NameEn = "Infrastructure", NameAr = "بنية الأنظمة", LookupCategoryId = 200 },
                new Lookup { Id = 7, Code = 5, NameEn = "UI_UX", NameAr = "واجهة المستخدم وتجربة المستخدم", LookupCategoryId = 200 },
                new Lookup { Id = 8, Code = 6, NameEn = "HumanResources", NameAr = "الموارد البشرية", LookupCategoryId = 200 },
                new Lookup { Id = 9, Code = 7, NameEn = "Finance", NameAr = "المالية", LookupCategoryId = 200 },
                new Lookup { Id = 10, Code = 8, NameEn = "AI", NameAr = "الذكاء الاصطناعي", LookupCategoryId = 200 },

                // Training Status Lookups
                new Lookup { Id = 11, Code = 1, NameEn = "Active", NameAr = "نشط", LookupCategoryId = 300 },
                new Lookup { Id = 12, Code = 2, NameEn = "Pending", NameAr = "قيد الانتظار", LookupCategoryId = 300 },
                new Lookup { Id = 13, Code = 3, NameEn = "Finished", NameAr = "مكتمل", LookupCategoryId = 300 },

                // Training Result Lookups
                new Lookup { Id = 14, Code = 1, NameEn = "Joining_TPS_Team", NameAr = "الانضمام إلى فريق TPS", LookupCategoryId = 400 },
                new Lookup { Id = 15, Code = 2, NameEn = "On_Hold", NameAr = "معلق", LookupCategoryId = 400 },
                new Lookup { Id = 16, Code = 3, NameEn = "Rejected", NameAr = "مرفوض", LookupCategoryId = 400 },
                new Lookup { Id = 17, Code = 4, NameEn = "Quit", NameAr = "استقال", LookupCategoryId = 400 }
            );
        }
    }
}

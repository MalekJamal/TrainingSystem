using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
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
                new LookupCategory { CategoryId = 100, Code = 1, NameEn = "Training Type", 
                    NameAr = "نوع التدريب", CreatedBy = "Malek Hamdan", IsActive = true, IsDeleted = false, 
                    CreatedOn = DateTime.Now, ModifyBy = null, Description = "Training Type That TPS Provided"
                },
                new LookupCategory { CategoryId = 200, Code = 2, NameEn = "Training Topics", NameAr = "موضوعات التدريب",
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = "Training Topics That TPS Provided"
                },
                new LookupCategory { CategoryId = 300, Code = 3, NameEn = "Training Status", NameAr = "حالة التدريب",
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = "Training Status"
                },
                new LookupCategory { CategoryId = 400, Code = 4, NameEn = "Training Result", NameAr = "نتيجة التدريب",
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = "Training Result"
                },
                new LookupCategory { CategoryId = 500, Code = 5, NameEn = "Trainer Name", NameAr = "أسم المدرب",
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = "Trainer Name"
                },
                new LookupCategory { CategoryId = 600, Code = 6, NameEn = "Year", NameAr = "السنة",
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = "Training Year That TPS Provided"
                }
            );

            // Seed data for Lookups using enum values
            modelBuilder.Entity<Lookup>().HasData(
                // Training Type Lookups
                new Lookup { Id = 1, Code = 1, NameEn = "Work", NameAr = "عمل", LookupCategoryId = 100,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 2, Code = 2, NameEn = "University", NameAr = "جامعة", LookupCategoryId = 100,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },

                // Training Topics Lookups
                new Lookup { Id = 3, Code = 1, NameEn = "DotNet", NameAr = ".Net", LookupCategoryId = 200,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 4, Code = 2, NameEn = "BusinessAnalyst", NameAr = "محلل أعمال", LookupCategoryId = 200,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 5, Code = 3, NameEn = "QualityControl", NameAr = "مراقبة الجودة", LookupCategoryId = 200,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 6, Code = 4, NameEn = "Infrastructure", NameAr = "بنية الأنظمة", LookupCategoryId = 200,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 7, Code = 5, NameEn = "UI_UX", NameAr = "واجهة المستخدم وتجربة المستخدم", LookupCategoryId = 200,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 8, Code = 6, NameEn = "HumanResources", NameAr = "الموارد البشرية", LookupCategoryId = 200,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 9, Code = 7, NameEn = "Finance", NameAr = "المالية", LookupCategoryId = 200,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 10, Code = 8, NameEn = "AI", NameAr = "الذكاء الاصطناعي", LookupCategoryId = 200,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },

                // Training Status Lookups
                new Lookup { Id = 11, Code = 1, NameEn = "Active", NameAr = "نشط", LookupCategoryId = 300,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 12, Code = 2, NameEn = "Pending", NameAr = "قيد الانتظار", LookupCategoryId = 300,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 13, Code = 3, NameEn = "Finished", NameAr = "مكتمل", LookupCategoryId = 300,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },

                // Training Result Lookups
                new Lookup { Id = 14, Code = 1, NameEn = "Joining_TPS_Team", NameAr = "الانضمام إلى فريق TPS", LookupCategoryId = 400,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 15, Code = 2, NameEn = "On_Hold", NameAr = "معلق", LookupCategoryId = 400,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 16, Code = 3, NameEn = "Rejected", NameAr = "مرفوض", LookupCategoryId = 400,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 17, Code = 4, NameEn = "Quit", NameAr = "استقال", LookupCategoryId = 400,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },

                // Trainer Lookups

                new Lookup { Id = 18, Code = 1, NameEn = "Khalid_Salameh", NameAr = "خالد سلامة", LookupCategoryId = 500,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 19, Code = 2, NameEn = "Lamees_Hourani", NameAr = "لميس حوراني", LookupCategoryId = 500,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 20, Code = 3, NameEn = "Mariam_AlSadawi", NameAr = "مريم السعداوي", LookupCategoryId = 500,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 21, Code = 4, NameEn = "Mohammad_Hamad", NameAr = "محمد حماد", LookupCategoryId = 500,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 22, Code = 5, NameEn = "Mohammad_Ibdah", NameAr = "محمد عبده", LookupCategoryId = 500,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 23, Code = 6, NameEn = "Safaa", NameAr = "صفاء", LookupCategoryId = 500,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 24, Code = 7, NameEn = "Zakaria_Lafi", NameAr = "زكريا لافي", LookupCategoryId = 500,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 25, Code = 8, NameEn = "Ahmed_Sweilem", NameAr = "أحمد سويلم", LookupCategoryId = 500,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },

                // Year Lookups
                new Lookup { Id = 26, Code = 1, NameEn = "Year2023", NameAr = "Year2023", LookupCategoryId = 600,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 27, Code = 2, NameEn = "Year2024", NameAr = "Year2024", LookupCategoryId = 600,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 28, Code = 3, NameEn = "Year2025", NameAr = "Year2025", LookupCategoryId = 600,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 29, Code = 4, NameEn = "Year2026", NameAr = "Year2026", LookupCategoryId = 600,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 30, Code = 5, NameEn = "Year2027", NameAr = "Year2027", LookupCategoryId = 600,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 31, Code = 6, NameEn = "Year2028", NameAr = "Year2028", LookupCategoryId = 600,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 32, Code = 7, NameEn = "Year2029", NameAr = "Year2029", LookupCategoryId = 600,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 33, Code = 8, NameEn = "Year2030", NameAr = "Year2030", LookupCategoryId = 600,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                },
                new Lookup { Id = 34, Code = 9, NameEn = "Year2031", NameAr = "Year2031", LookupCategoryId = 600,
                    CreatedBy = "Malek Hamdan",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    ModifyBy = null,
                    Description = ""
                }


            );
        }
    }
}

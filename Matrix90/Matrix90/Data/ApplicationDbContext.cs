using System;
using System.Collections.Generic;
using System.Text;
using Matrix90.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Matrix90.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)



        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole 
                    { Name = "Customer", 
                      NormalizedName = "CUSTOMER"
                    },
                new IdentityRole 
                    { 
                        Name = "Nutritionist", 
                        NormalizedName = "NUTRITIONIST" 
                    }
                );
        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Nutritionist> Nutritionists { get; set; }
        public DbSet<CustomerActivityInfo> CustomerActivityInfos { get; set; }
        public DbSet<CustomerEatingHabits> CustomerEatingHabitss { get; set; }
        public DbSet<CustomerMeasurements> CustomerMeasurementss { get; set; }
        public DbSet<CustomerMedicalInfo> CustomerMedicalInfos { get; set; }
        public DbSet<CustomerRecordBook> CustomerRecordBooks { get; set; }
        public DbSet<CustomerTypicalDayInfo> CustomerTypicalDayInfos { get; set; }
        public DbSet<CustomerWorkInfo> CustomerWorkInfos { get; set; }
        public DbSet<FavoriteTip> FavoriteTips { get; set; }
        public DbSet<NutritionPlan> NutritionPlans { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<TipOfWeek> TipOfWeeks { get; set; }
        public DbSet<Image> Images { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        

    }
}

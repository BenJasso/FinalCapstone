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
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Customer", NormalizedName = "CUSTOMER" }, new IdentityRole { Name = "Nutritionist", NormalizedName = "NUTRITIONIST" });
        }


        DbSet<Customer> Customers { get; set; }
        DbSet<Nutritionist> Nutritionists { get; set; }
        DbSet<CustomerActivityInfo> CustomerActivityInfos { get; set; }
        DbSet<CustomerEatingHabits> CustomerEatingHabitss { get; set; }
        DbSet<CustomerMeasurements> CustomerMeasurementss { get; set; }
        DbSet<CustomerMedicalInfo> CustomerMedicalInfos { get; set; }
        DbSet<CustomerRecordBook> CustomerRecordBooks { get; set; }
        DbSet<CustomerTypicalDayInfo> CustomerTypicalDayInfos { get; set; }
        DbSet<CustomerWorkInfo> CustomerWorkInfos { get; set; }
        DbSet<FavoriteTip> FavoriteTips { get; set; }
        DbSet<NutritionPlan> NutritionPlans { get; set; }
        DbSet<Recipe> Recipes { get; set; }
        DbSet<TipOfWeek> TipOfWeeks { get; set; }

        

    }
}

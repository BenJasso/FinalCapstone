using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Matrix90.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerActivityInfos",
                columns: table => new
                {
                    CustomerActivityInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    AccessToFacility = table.Column<bool>(nullable: false),
                    WorkoutRoutine = table.Column<bool>(nullable: false),
                    RoutineTimePerDay = table.Column<int>(nullable: false),
                    RoutineDaysAWeek = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerActivityInfos", x => x.CustomerActivityInfoId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerEatingHabitss",
                columns: table => new
                {
                    CustomerEatingHabitsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    TypicalBreakfast = table.Column<string>(nullable: true),
                    TypicalLunch = table.Column<string>(nullable: true),
                    TypicalDinner = table.Column<string>(nullable: true),
                    TypicalSnack = table.Column<string>(nullable: true),
                    DrinkSodaAmount = table.Column<int>(nullable: false),
                    DrinkAlcoholAmount = table.Column<int>(nullable: false),
                    FoodAllergies = table.Column<bool>(nullable: false),
                    KindOfFoodAllergies = table.Column<string>(nullable: true),
                    FavoriteFoods = table.Column<string>(nullable: true),
                    NonFavoriteFoods = table.Column<string>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerEatingHabitss", x => x.CustomerEatingHabitsId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerMeasurementss",
                columns: table => new
                {
                    CustomerMeasurementsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    CurrentWeight = table.Column<int>(nullable: false),
                    GoalWeight = table.Column<int>(nullable: false),
                    Wrist = table.Column<int>(nullable: false),
                    Forearm = table.Column<int>(nullable: false),
                    Hips = table.Column<int>(nullable: false),
                    Waist = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerMeasurementss", x => x.CustomerMeasurementsId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerMedicalInfos",
                columns: table => new
                {
                    CustomerMedicalInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    MedicalConditions = table.Column<string>(nullable: true),
                    Injuries = table.Column<string>(nullable: true),
                    PhysicalActivityLimitations = table.Column<string>(nullable: true),
                    GastroIntestinalDiscomfort = table.Column<bool>(nullable: false),
                    GastroInfo = table.Column<string>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerMedicalInfos", x => x.CustomerMedicalInfoId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerRecordBooks",
                columns: table => new
                {
                    CustomerRecordBookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRecordBooks", x => x.CustomerRecordBookId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypicalDayInfos",
                columns: table => new
                {
                    CustomerTypicalDayInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    WakeUpTime = table.Column<double>(nullable: false),
                    BedTime = table.Column<double>(nullable: false),
                    SleepDifficulty = table.Column<bool>(nullable: false),
                    NightlyWakeUps = table.Column<int>(nullable: false),
                    BreakfastTime = table.Column<double>(nullable: false),
                    LunchTime = table.Column<double>(nullable: false),
                    DinnerTime = table.Column<double>(nullable: false),
                    SnackDuringDay = table.Column<bool>(nullable: false),
                    SnackDuringDayTimes = table.Column<double>(nullable: false),
                    EatingTimeFlexibility = table.Column<bool>(nullable: false),
                    AdditionalInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypicalDayInfos", x => x.CustomerTypicalDayInfoId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerWorkInfos",
                columns: table => new
                {
                    CustomerWorkInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    Occupation = table.Column<string>(nullable: true),
                    Shift = table.Column<string>(nullable: true),
                    WorkDays = table.Column<string>(nullable: true),
                    DailyWorkHours = table.Column<string>(nullable: true),
                    ScheduledBreaks = table.Column<bool>(nullable: false),
                    BringLunchAbility = table.Column<bool>(nullable: false),
                    ActivityLevel = table.Column<string>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerWorkInfos", x => x.CustomerWorkInfoId);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteTips",
                columns: table => new
                {
                    FavoriteTipId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipOfWeekId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteTips", x => x.FavoriteTipId);
                });

            migrationBuilder.CreateTable(
                name: "Nutritionists",
                columns: table => new
                {
                    NutritionistId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<double>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutritionists", x => x.NutritionistId);
                    table.ForeignKey(
                        name: "FK_Nutritionists_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NutritionPlans",
                columns: table => new
                {
                    NutritionPlanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    Meal1Time = table.Column<double>(nullable: false),
                    Meal1Entree = table.Column<string>(nullable: true),
                    Meal1EntreeSize = table.Column<int>(nullable: false),
                    Meal1Vegetable = table.Column<string>(nullable: true),
                    Meal1VegetableSize = table.Column<int>(nullable: false),
                    Meal1Carb = table.Column<string>(nullable: true),
                    Meal1CarbSize = table.Column<int>(nullable: false),
                    Meal2Time = table.Column<double>(nullable: false),
                    Meal2Entree = table.Column<string>(nullable: true),
                    Meal2EntreeSize = table.Column<int>(nullable: false),
                    Meal2Vegetable = table.Column<string>(nullable: true),
                    Meal2VegetableSize = table.Column<int>(nullable: false),
                    Meal2Carb = table.Column<string>(nullable: true),
                    Meal2CarbSize = table.Column<int>(nullable: false),
                    Meal3Time = table.Column<double>(nullable: false),
                    Meal3Entree = table.Column<string>(nullable: true),
                    Meal3EntreeSize = table.Column<int>(nullable: false),
                    Meal3Vegetable = table.Column<string>(nullable: true),
                    Meal3VegetableSize = table.Column<int>(nullable: false),
                    Meal3Carb = table.Column<string>(nullable: true),
                    Meal3CarbSize = table.Column<int>(nullable: false),
                    Meal4Time = table.Column<double>(nullable: false),
                    Meal4Entree = table.Column<string>(nullable: true),
                    Meal4EntreeSize = table.Column<int>(nullable: false),
                    Meal4Vegetable = table.Column<string>(nullable: true),
                    Meal4VegetableSize = table.Column<int>(nullable: false),
                    Meal4Carb = table.Column<string>(nullable: true),
                    Meal4CarbSize = table.Column<int>(nullable: false),
                    Meal5Time = table.Column<double>(nullable: false),
                    Meal5Entree = table.Column<string>(nullable: true),
                    Meal5EntreeSize = table.Column<int>(nullable: false),
                    Meal5Vegetable = table.Column<string>(nullable: true),
                    Meal5VegetableSize = table.Column<int>(nullable: false),
                    Meal5Carb = table.Column<string>(nullable: true),
                    Meal5CarbSize = table.Column<int>(nullable: false),
                    Meal6Time = table.Column<double>(nullable: false),
                    Meal6Entree = table.Column<string>(nullable: true),
                    Meal6EntreeSize = table.Column<int>(nullable: false),
                    Meal6Vegetable = table.Column<string>(nullable: true),
                    Meal6VegetableSize = table.Column<int>(nullable: false),
                    Meal6Carb = table.Column<string>(nullable: true),
                    Meal6CarbSize = table.Column<int>(nullable: false),
                    Snack1Time = table.Column<double>(nullable: false),
                    Snack1 = table.Column<string>(nullable: true),
                    Snack1Size = table.Column<int>(nullable: false),
                    Snack2Time = table.Column<double>(nullable: false),
                    Snack2 = table.Column<string>(nullable: true),
                    Snack2Size = table.Column<int>(nullable: false),
                    Snack3Time = table.Column<double>(nullable: false),
                    Snack3 = table.Column<string>(nullable: true),
                    Snack3Size = table.Column<int>(nullable: false),
                    Supplement1 = table.Column<string>(nullable: true),
                    Supplement2 = table.Column<string>(nullable: true),
                    Supplement3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionPlans", x => x.NutritionPlanId);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    RecipeInfo = table.Column<string>(nullable: true),
                    RecipeImage = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                });

            migrationBuilder.CreateTable(
                name: "TipOfWeeks",
                columns: table => new
                {
                    TipOfWeekId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(nullable: true),
                    Tip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipOfWeeks", x => x.TipOfWeekId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1b100cf-32ad-48c0-b4ad-92e293066e4c", "064113d2-366d-4ee2-8a4c-6e6c9310c9e1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db577175-6152-4eb8-9dee-ef233d930bed", "195ec22b-faaf-4cfb-a554-a2d7bdf881a3", "Nutritionist", "NUTRITIONIST" });

            migrationBuilder.CreateIndex(
                name: "IX_Nutritionists_IdentityUserId",
                table: "Nutritionists",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerActivityInfos");

            migrationBuilder.DropTable(
                name: "CustomerEatingHabitss");

            migrationBuilder.DropTable(
                name: "CustomerMeasurementss");

            migrationBuilder.DropTable(
                name: "CustomerMedicalInfos");

            migrationBuilder.DropTable(
                name: "CustomerRecordBooks");

            migrationBuilder.DropTable(
                name: "CustomerTypicalDayInfos");

            migrationBuilder.DropTable(
                name: "CustomerWorkInfos");

            migrationBuilder.DropTable(
                name: "FavoriteTips");

            migrationBuilder.DropTable(
                name: "Nutritionists");

            migrationBuilder.DropTable(
                name: "NutritionPlans");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "TipOfWeeks");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db577175-6152-4eb8-9dee-ef233d930bed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1b100cf-32ad-48c0-b4ad-92e293066e4c");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Matrix90.Data.Migrations
{
    public partial class changedtimepropertiestostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dde4410f-69bc-4746-8d4a-92453d9b2d35");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de507859-c86b-4426-afaa-57629764d45f");

            migrationBuilder.AlterColumn<string>(
                name: "Snack3Time",
                table: "NutritionPlans",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Snack2Time",
                table: "NutritionPlans",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Snack1Time",
                table: "NutritionPlans",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Meal6Time",
                table: "NutritionPlans",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Meal5Time",
                table: "NutritionPlans",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Meal4Time",
                table: "NutritionPlans",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Meal3Time",
                table: "NutritionPlans",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Meal2Time",
                table: "NutritionPlans",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Meal1Time",
                table: "NutritionPlans",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "WakeUpTime",
                table: "CustomerTypicalDayInfos",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "LunchTime",
                table: "CustomerTypicalDayInfos",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "DinnerTime",
                table: "CustomerTypicalDayInfos",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "BreakfastTime",
                table: "CustomerTypicalDayInfos",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "BedTime",
                table: "CustomerTypicalDayInfos",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9922fddd-4242-47d0-a6e3-539510285ce5", "d3e1a91e-635c-4926-a775-b5bf96762ced", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e777883-6188-4c43-9202-da2a2457b0b7", "539a5c52-a37d-422d-8281-0ef24dd9764a", "Nutritionist", "NUTRITIONIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e777883-6188-4c43-9202-da2a2457b0b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9922fddd-4242-47d0-a6e3-539510285ce5");

            migrationBuilder.AlterColumn<double>(
                name: "Snack3Time",
                table: "NutritionPlans",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Snack2Time",
                table: "NutritionPlans",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Snack1Time",
                table: "NutritionPlans",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Meal6Time",
                table: "NutritionPlans",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Meal5Time",
                table: "NutritionPlans",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Meal4Time",
                table: "NutritionPlans",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Meal3Time",
                table: "NutritionPlans",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Meal2Time",
                table: "NutritionPlans",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Meal1Time",
                table: "NutritionPlans",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "WakeUpTime",
                table: "CustomerTypicalDayInfos",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "LunchTime",
                table: "CustomerTypicalDayInfos",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "DinnerTime",
                table: "CustomerTypicalDayInfos",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "BreakfastTime",
                table: "CustomerTypicalDayInfos",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "BedTime",
                table: "CustomerTypicalDayInfos",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de507859-c86b-4426-afaa-57629764d45f", "dedac552-eb3e-4faf-84de-59cfe590bd16", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dde4410f-69bc-4746-8d4a-92453d9b2d35", "88f1d93a-cca1-4e2b-891d-13efc728d9a3", "Nutritionist", "NUTRITIONIST" });
        }
    }
}

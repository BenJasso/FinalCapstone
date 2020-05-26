using Microsoft.EntityFrameworkCore.Migrations;

namespace Matrix90.Data.Migrations
{
    public partial class changedforeignkeystoidentityuserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "530f5e8f-9e13-4d95-acca-310e7af00f25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "994288f9-2def-4e2c-9fbb-b158d8fee7bb");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerWorkInfos");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerTypicalDayInfos");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerMedicalInfos");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerMeasurementss");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerEatingHabitss");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerActivityInfos");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "CustomerWorkInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "CustomerTypicalDayInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "CustomerMedicalInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "CustomerMeasurementss",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "CustomerEatingHabitss",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "CustomerActivityInfos",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2a1d2bd-ef55-4121-968e-1e91b0643c34", "00c0b36d-60d3-4d93-8e75-2136c9df429f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a99931bf-fffd-439c-8278-9aa26b392017", "6a314e72-adf7-4b23-a69f-82d55dc4bd42", "Nutritionist", "NUTRITIONIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a99931bf-fffd-439c-8278-9aa26b392017");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2a1d2bd-ef55-4121-968e-1e91b0643c34");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "CustomerWorkInfos");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "CustomerTypicalDayInfos");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "CustomerMedicalInfos");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "CustomerMeasurementss");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "CustomerEatingHabitss");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "CustomerActivityInfos");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CustomerWorkInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CustomerTypicalDayInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CustomerMedicalInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CustomerMeasurementss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CustomerEatingHabitss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CustomerActivityInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "530f5e8f-9e13-4d95-acca-310e7af00f25", "0e13117d-a387-4972-905d-7558832030c1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "994288f9-2def-4e2c-9fbb-b158d8fee7bb", "3b39e0e5-4167-434f-b1e3-287bcb6078cb", "Nutritionist", "NUTRITIONIST" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Matrix90.Data.Migrations
{
    public partial class addeduploaddatepropertytorecipeandtips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ed1f23a-c0e4-4362-941a-1341486e72e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3418e05-56c1-4862-86eb-dc69e6d09702");

            migrationBuilder.AddColumn<DateTime>(
                name: "uploadDate",
                table: "TipOfWeeks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "uploadDate",
                table: "Recipes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec6db505-a80b-48af-b862-8e6ac84e47fb", "dc431db7-c9ae-43a3-a120-a180bd8425ff", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0699410d-af1b-4389-a86e-1b74d7873aec", "22b66a28-a2fa-4c7d-a88a-94e224473d1c", "Nutritionist", "NUTRITIONIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0699410d-af1b-4389-a86e-1b74d7873aec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec6db505-a80b-48af-b862-8e6ac84e47fb");

            migrationBuilder.DropColumn(
                name: "uploadDate",
                table: "TipOfWeeks");

            migrationBuilder.DropColumn(
                name: "uploadDate",
                table: "Recipes");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0ed1f23a-c0e4-4362-941a-1341486e72e7", "86da85d3-268a-40d7-a41e-4569181a4b7d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3418e05-56c1-4862-86eb-dc69e6d09702", "392dd115-abac-4d63-87ee-bd1e5f005097", "Nutritionist", "NUTRITIONIST" });
        }
    }
}

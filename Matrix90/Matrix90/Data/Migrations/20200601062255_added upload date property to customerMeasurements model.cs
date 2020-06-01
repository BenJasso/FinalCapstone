using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Matrix90.Data.Migrations
{
    public partial class addeduploaddatepropertytocustomerMeasurementsmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0df8b803-c737-4b85-bc52-df37eed2dd1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b26361d-4cc4-41c3-8c92-e7df780f0b30");

            migrationBuilder.AddColumn<DateTime>(
                name: "uploadDate",
                table: "CustomerMeasurementss",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de507859-c86b-4426-afaa-57629764d45f", "dedac552-eb3e-4faf-84de-59cfe590bd16", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dde4410f-69bc-4746-8d4a-92453d9b2d35", "88f1d93a-cca1-4e2b-891d-13efc728d9a3", "Nutritionist", "NUTRITIONIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dde4410f-69bc-4746-8d4a-92453d9b2d35");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de507859-c86b-4426-afaa-57629764d45f");

            migrationBuilder.DropColumn(
                name: "uploadDate",
                table: "CustomerMeasurementss");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0df8b803-c737-4b85-bc52-df37eed2dd1c", "bd7a4ede-6975-48a2-b2e3-b704b4ae4192", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b26361d-4cc4-41c3-8c92-e7df780f0b30", "40dbbbd4-adea-4eb1-aea9-b3a75700968e", "Nutritionist", "NUTRITIONIST" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Matrix90.Data.Migrations
{
    public partial class addedcontrollerActionpropertytonotificationmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "078be5a7-b5c0-4665-8bc9-ce359bbfcad2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ceca265-f89b-4fde-b94d-17290b8322f2");

            migrationBuilder.AddColumn<string>(
                name: "controllerAction",
                table: "Notifications",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0df8b803-c737-4b85-bc52-df37eed2dd1c", "bd7a4ede-6975-48a2-b2e3-b704b4ae4192", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b26361d-4cc4-41c3-8c92-e7df780f0b30", "40dbbbd4-adea-4eb1-aea9-b3a75700968e", "Nutritionist", "NUTRITIONIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0df8b803-c737-4b85-bc52-df37eed2dd1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b26361d-4cc4-41c3-8c92-e7df780f0b30");

            migrationBuilder.DropColumn(
                name: "controllerAction",
                table: "Notifications");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "078be5a7-b5c0-4665-8bc9-ce359bbfcad2", "26314d63-e501-4515-b240-6db465f2aa45", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ceca265-f89b-4fde-b94d-17290b8322f2", "d03c0795-282d-4998-92af-6e1612307978", "Nutritionist", "NUTRITIONIST" });
        }
    }
}

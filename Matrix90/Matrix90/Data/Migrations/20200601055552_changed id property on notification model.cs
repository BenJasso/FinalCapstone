using Microsoft.EntityFrameworkCore.Migrations;

namespace Matrix90.Data.Migrations
{
    public partial class changedidpropertyonnotificationmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d119995-6d50-4d28-8180-4ba8011d7238");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9935c6b6-9233-4be5-b084-884b13b16f36");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Notifications",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "078be5a7-b5c0-4665-8bc9-ce359bbfcad2", "26314d63-e501-4515-b240-6db465f2aa45", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ceca265-f89b-4fde-b94d-17290b8322f2", "d03c0795-282d-4998-92af-6e1612307978", "Nutritionist", "NUTRITIONIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "078be5a7-b5c0-4665-8bc9-ce359bbfcad2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ceca265-f89b-4fde-b94d-17290b8322f2");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Notifications",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9935c6b6-9233-4be5-b084-884b13b16f36", "bed9a83f-bcc9-40cf-b6e8-d888d9370618", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d119995-6d50-4d28-8180-4ba8011d7238", "219d6517-c956-43be-b44d-e6014aef6d6c", "Nutritionist", "NUTRITIONIST" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Matrix90.Data.Migrations
{
    public partial class addedtipTitletoTipmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52b45a22-6684-49aa-90b7-1db0bb50fb92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68747194-2cc0-4b8d-8c21-e0887f3a7a93");

            migrationBuilder.AddColumn<string>(
                name: "TipTitle",
                table: "TipOfWeeks",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5e880540-6983-4c70-bcf2-da9d3a5d13ee", "1c67c4ff-7cd3-4536-aca2-a36f18bc2f12", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "185b2734-7cd2-4d41-9691-30b5bae83ce7", "3aeb4045-3fc3-4089-93b1-15a41d074404", "Nutritionist", "NUTRITIONIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "185b2734-7cd2-4d41-9691-30b5bae83ce7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e880540-6983-4c70-bcf2-da9d3a5d13ee");

            migrationBuilder.DropColumn(
                name: "TipTitle",
                table: "TipOfWeeks");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68747194-2cc0-4b8d-8c21-e0887f3a7a93", "3264158c-e857-4598-b39f-0f6cadd3c4cc", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52b45a22-6684-49aa-90b7-1db0bb50fb92", "c10eacd4-f6e5-4669-9d0f-b1652f537019", "Nutritionist", "NUTRITIONIST" });
        }
    }
}

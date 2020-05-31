using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Matrix90.Data.Migrations
{
    public partial class addedrecipeViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0699410d-af1b-4389-a86e-1b74d7873aec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec6db505-a80b-48af-b862-8e6ac84e47fb");

            migrationBuilder.AlterColumn<string>(
                name: "RecipeImage",
                table: "Recipes",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68747194-2cc0-4b8d-8c21-e0887f3a7a93", "3264158c-e857-4598-b39f-0f6cadd3c4cc", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52b45a22-6684-49aa-90b7-1db0bb50fb92", "c10eacd4-f6e5-4669-9d0f-b1652f537019", "Nutritionist", "NUTRITIONIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52b45a22-6684-49aa-90b7-1db0bb50fb92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68747194-2cc0-4b8d-8c21-e0887f3a7a93");

            migrationBuilder.AlterColumn<byte[]>(
                name: "RecipeImage",
                table: "Recipes",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec6db505-a80b-48af-b862-8e6ac84e47fb", "dc431db7-c9ae-43a3-a120-a180bd8425ff", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0699410d-af1b-4389-a86e-1b74d7873aec", "22b66a28-a2fa-4c7d-a88a-94e224473d1c", "Nutritionist", "NUTRITIONIST" });
        }
    }
}

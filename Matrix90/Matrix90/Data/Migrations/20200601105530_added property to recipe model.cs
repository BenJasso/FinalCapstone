using Microsoft.EntityFrameworkCore.Migrations;

namespace Matrix90.Data.Migrations
{
    public partial class addedpropertytorecipemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e777883-6188-4c43-9202-da2a2457b0b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9922fddd-4242-47d0-a6e3-539510285ce5");

            migrationBuilder.AddColumn<string>(
                name: "RecipeTitle",
                table: "Recipes",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2cbf369-d443-464f-b066-152498bcd0ae", "04961ebc-4cbc-43f2-977b-28b4e87eeb0f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81886ccb-9cdc-424d-b16d-60e7436af45b", "b8798c2b-d8bc-425e-9aa3-bfd42d53c29e", "Nutritionist", "NUTRITIONIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81886ccb-9cdc-424d-b16d-60e7436af45b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2cbf369-d443-464f-b066-152498bcd0ae");

            migrationBuilder.DropColumn(
                name: "RecipeTitle",
                table: "Recipes");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9922fddd-4242-47d0-a6e3-539510285ce5", "d3e1a91e-635c-4926-a775-b5bf96762ced", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e777883-6188-4c43-9202-da2a2457b0b7", "539a5c52-a37d-422d-8281-0ef24dd9764a", "Nutritionist", "NUTRITIONIST" });
        }
    }
}

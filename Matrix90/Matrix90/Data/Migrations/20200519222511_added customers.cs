using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Matrix90.Data.Migrations
{
    public partial class addedcustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db577175-6152-4eb8-9dee-ef233d930bed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1b100cf-32ad-48c0-b4ad-92e293066e4c");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    CityAddress = table.Column<string>(nullable: true),
                    StateAddress = table.Column<string>(nullable: true),
                    ZipAddress = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<double>(nullable: false),
                    PrefferedMethodOfContact = table.Column<string>(nullable: true),
                    BestTimeToReach = table.Column<string>(nullable: true),
                    FrontImage = table.Column<byte[]>(nullable: true),
                    BackImage = table.Column<byte[]>(nullable: true),
                    ProfileRight = table.Column<byte[]>(nullable: true),
                    ProfileLeft = table.Column<byte[]>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7b608f72-2564-41b3-bb31-336594cd0631", "4f209bff-d440-4035-b35f-e3ed5cae2303", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11547d03-f050-4840-8c10-d27af4810aa0", "ffc38354-b4d4-4b0f-ac4c-b867e8161f32", "Nutritionist", "NUTRITIONIST" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11547d03-f050-4840-8c10-d27af4810aa0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b608f72-2564-41b3-bb31-336594cd0631");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1b100cf-32ad-48c0-b4ad-92e293066e4c", "064113d2-366d-4ee2-8a4c-6e6c9310c9e1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db577175-6152-4eb8-9dee-ef233d930bed", "195ec22b-faaf-4cfb-a554-a2d7bdf881a3", "Nutritionist", "NUTRITIONIST" });
        }
    }
}

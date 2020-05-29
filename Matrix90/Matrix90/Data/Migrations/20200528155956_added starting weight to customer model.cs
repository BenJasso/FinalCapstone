using Microsoft.EntityFrameworkCore.Migrations;

namespace Matrix90.Data.Migrations
{
    public partial class addedstartingweighttocustomermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a99931bf-fffd-439c-8278-9aa26b392017");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2a1d2bd-ef55-4121-968e-1e91b0643c34");

            migrationBuilder.AddColumn<int>(
                name: "StartingWeight",
                table: "CustomerMeasurementss",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dfc38330-4cc9-45aa-95d0-cf488f5b3195", "4d71dbb8-4bca-4d7f-b6f1-36e76ee87c93", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7df68141-57b7-4fb8-8b5b-576ab737cb40", "e4855aff-67d0-442a-b4f7-63f4049d57ec", "Nutritionist", "NUTRITIONIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7df68141-57b7-4fb8-8b5b-576ab737cb40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfc38330-4cc9-45aa-95d0-cf488f5b3195");

            migrationBuilder.DropColumn(
                name: "StartingWeight",
                table: "CustomerMeasurementss");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2a1d2bd-ef55-4121-968e-1e91b0643c34", "00c0b36d-60d3-4d93-8e75-2136c9df429f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a99931bf-fffd-439c-8278-9aa26b392017", "6a314e72-adf7-4b23-a69f-82d55dc4bd42", "Nutritionist", "NUTRITIONIST" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Matrix90.Data.Migrations
{
    public partial class changedmeasurementproperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Forearm",
                table: "CustomerMeasurementss");

            migrationBuilder.DropColumn(
                name: "Wrist",
                table: "CustomerMeasurementss");

            migrationBuilder.AddColumn<int>(
                name: "Arms",
                table: "CustomerMeasurementss",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Calves",
                table: "CustomerMeasurementss",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Chest",
                table: "CustomerMeasurementss",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Neck",
                table: "CustomerMeasurementss",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Thigh",
                table: "CustomerMeasurementss",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0ed1f23a-c0e4-4362-941a-1341486e72e7", "86da85d3-268a-40d7-a41e-4569181a4b7d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3418e05-56c1-4862-86eb-dc69e6d09702", "392dd115-abac-4d63-87ee-bd1e5f005097", "Nutritionist", "NUTRITIONIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ed1f23a-c0e4-4362-941a-1341486e72e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3418e05-56c1-4862-86eb-dc69e6d09702");

            migrationBuilder.DropColumn(
                name: "Arms",
                table: "CustomerMeasurementss");

            migrationBuilder.DropColumn(
                name: "Calves",
                table: "CustomerMeasurementss");

            migrationBuilder.DropColumn(
                name: "Chest",
                table: "CustomerMeasurementss");

            migrationBuilder.DropColumn(
                name: "Neck",
                table: "CustomerMeasurementss");

            migrationBuilder.DropColumn(
                name: "Thigh",
                table: "CustomerMeasurementss");

            migrationBuilder.AddColumn<int>(
                name: "Forearm",
                table: "CustomerMeasurementss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Wrist",
                table: "CustomerMeasurementss",
                type: "int",
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
    }
}

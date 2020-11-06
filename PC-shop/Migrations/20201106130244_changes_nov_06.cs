using Microsoft.EntityFrameworkCore.Migrations;

namespace PC_shop.Migrations
{
    public partial class changes_nov_06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CpuList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Core x10");

            migrationBuilder.UpdateData(
                table: "CpuList",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Core x8");

            migrationBuilder.UpdateData(
                table: "CpuList",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Core x6");

            migrationBuilder.UpdateData(
                table: "CpuList",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "x8");

            migrationBuilder.UpdateData(
                table: "CpuList",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "x6");

            migrationBuilder.UpdateData(
                table: "CpuList",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "x4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CpuList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "intel x10");

            migrationBuilder.UpdateData(
                table: "CpuList",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "intel x8");

            migrationBuilder.UpdateData(
                table: "CpuList",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "intel x6");

            migrationBuilder.UpdateData(
                table: "CpuList",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "AMD x8");

            migrationBuilder.UpdateData(
                table: "CpuList",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "AMD x6");

            migrationBuilder.UpdateData(
                table: "CpuList",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "AMD x4");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace PC_shop.Migrations
{
    public partial class reSeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IntegratedVideoCard",
                table: "MotherBoardList");

            migrationBuilder.UpdateData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Resolution",
                value: "4650:2080");

            migrationBuilder.UpdateData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 2,
                column: "Resolution",
                value: "8500:1920");

            migrationBuilder.UpdateData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 3,
                column: "Resolution",
                value: "2150:1920");

            migrationBuilder.UpdateData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 4,
                column: "Resolution",
                value: "2150:1920");

            migrationBuilder.UpdateData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 5,
                column: "Resolution",
                value: "1920:1080");

            migrationBuilder.UpdateData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 6,
                column: "Resolution",
                value: "4550:1920");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IntegratedVideoCard",
                table: "MotherBoardList",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Resolution",
                value: "4650 x 2080");

            migrationBuilder.UpdateData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 2,
                column: "Resolution",
                value: "8500/1920");

            migrationBuilder.UpdateData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 3,
                column: "Resolution",
                value: "2150/1920");

            migrationBuilder.UpdateData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 4,
                column: "Resolution",
                value: "2150/1920");

            migrationBuilder.UpdateData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 5,
                column: "Resolution",
                value: "1920/1080");

            migrationBuilder.UpdateData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 6,
                column: "Resolution",
                value: "4550/1920");

            migrationBuilder.UpdateData(
                table: "MotherBoardList",
                keyColumn: "Id",
                keyValue: 1,
                column: "IntegratedVideoCard",
                value: true);

            migrationBuilder.UpdateData(
                table: "MotherBoardList",
                keyColumn: "Id",
                keyValue: 3,
                column: "IntegratedVideoCard",
                value: true);

            migrationBuilder.UpdateData(
                table: "MotherBoardList",
                keyColumn: "Id",
                keyValue: 4,
                column: "IntegratedVideoCard",
                value: true);
        }
    }
}

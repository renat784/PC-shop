using Microsoft.EntityFrameworkCore.Migrations;

namespace PC_shop.Migrations
{
    public partial class seed_ram2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RamList",
                columns: new[] { "Id", "Capacity", "CategoryId", "Frequency", "Images", "Make", "MemoryType", "Name", "Price", "Purpose" },
                values: new object[,]
                {
                    { 1, 32, 7, 2400, "kingston_kvr24n17s6_4_images_11390403828.jpg", "Intel", "DDR-4", "i4580", 1100, "Для настольных компьютеров" },
                    { 2, 16, 7, 2133, "kingston_kvr24n17d8_16_images_1735238670.jpg; kingston_kvr24n17d8_16_images_1735238817.jpg", "Intel", "DDR-4", "i80S", 800, "Для настольных компьютеров" },
                    { 3, 32, 7, 2400, "kingston_kvr13n9s8_4_images_6975524.jpg", "Kingston", "DDR-4", "k50-34", 1350, "Для настольных компьютеров" },
                    { 4, 8, 7, 2133, "kingston_kvr16ls11_8_images_83231304.jpg", "Intel", "SODIMM DDR4", "m32-3", 300, "Для ноутбуков" },
                    { 5, 32, 7, 4400, "kingston_kvr26n19s6_4_images_8900628336.jpg", "Kingston", "DDR-4", "D80 Pro 5", 2100, "Для настольных компьютеров" },
                    { 6, 128, 7, 5400, "copy_hyperx_hx430c16fb3k4_128_5e1f564adf3a8_images_16349879680.jpg", "HyperX", "DDR-4", "Fury Black", 6100, "Для серверов" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RamList",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RamList",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RamList",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RamList",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RamList",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RamList",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}

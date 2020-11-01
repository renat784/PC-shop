using Microsoft.EntityFrameworkCore.Migrations;

namespace PC_shop.Migrations
{
    public partial class seed_mb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MotherBoardList",
                columns: new[] { "Id", "CategoryId", "FormFactor", "Images", "IntegratedVideoCard", "Make", "MemorySupport", "Name", "Price", "Socket", "VideoExit" },
                values: new object[,]
                {
                    { 1, 5, "ATX", "asus_tuf_z390_plus_gaming_wi_fi_images_7904477637.jpg; asus_tuf_z390_plus_gaming_wi_fi_images_7904478087.jpg; asus_tuf_z390_plus_gaming_wi_fi_images_7904478861.jpg", true, "Asus", "1866", "I-PRO20", 800, "Socket 1567", "DVI" },
                    { 2, 5, "ATX", "218526139_images_18467982511.jpg", false, "Acer", "1333", "A99-50", 1700, "Socket 1366", "DVI" },
                    { 3, 5, "MicroATX", "gigabyte_x399_aorus_pro_images_10802381841.jpg; gigabyte_x399_aorus_pro_images_10802960535.jpg; gigabyte_x399_aorus_pro_images_10802383041.jpg", true, "Gigabyte", "1333", "G990 MAX", 1100, "Socket 1150", "HDMI" },
                    { 4, 5, "MicroATX", "191457449_images_17158409871.jpg", true, "HP", "1333", "H450i", 700, "Socket 1150", "HDMI" },
                    { 5, 5, "EATX", "msi_b450_tomahawk_max_images_13269008218.jpg; msi_b450_tomahawk_max_images_13269009592.jpg; msi_b450_tomahawk_max_images_13269011554.jpg", false, "MSI", "1600", "Q88 Pro", 500, "Socket 1155", "DisplayPort" },
                    { 6, 5, "MiniITX", "240799177_images_19528687813.jpg", false, "Intel", "1600", "I-350ZX", 300, "Socket 1155", "D-Sub" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MotherBoardList",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MotherBoardList",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MotherBoardList",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MotherBoardList",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MotherBoardList",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MotherBoardList",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}

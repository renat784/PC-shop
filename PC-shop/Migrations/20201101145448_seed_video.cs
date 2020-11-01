using Microsoft.EntityFrameworkCore.Migrations;

namespace PC_shop.Migrations
{
    public partial class seed_video : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chip",
                table: "VideoCarsList");

            migrationBuilder.InsertData(
                table: "VideoCarsList",
                columns: new[] { "Id", "CategoryId", "Images", "Make", "MemorySize", "MemoryType", "Name", "Price", "Purpose" },
                values: new object[,]
                {
                    { 1, 9, "234123103_images_19199193643.jpg; 234123103_images_19199194105.jpg; 234123103_images_19199194591.jpg", "NVIDEA", 4, "GDDR5", "GT 2510z", 400, "Обычные" },
                    { 2, 9, "234128197_images_19198957285.jpg; 234128197_images_19198957045.jpg", "NVIDEA", 4, "GDDR4", "GTX 780", 450, "Обычные" },
                    { 3, 9, "msi_gtx_1660_super_ventus_xs_oc_images_14954879417.png; msi_gtx_1660_super_ventus_xs_oc_images_14954879774.png; msi_gtx_1660_super_ventus_xs_oc_images_14954880467.png", "MSI", 12, "GDDR5", "MX 250 Super", 450, "Игровые" },
                    { 4, 9, "msi_rtx_3070_ventus_2x_oc_images_20161643341.png; msi_rtx_3070_ventus_2x_oc_images_20161644331.png; msi_rtx_3070_ventus_2x_oc_images_20161645501.png", "MSI", 10, "GDDR5", "M1 Hero", 600, "Игровые" },
                    { 5, 9, "116106877_images_13695811621.jpg", "AMD", 8, "GDDR5", "RXi 500", 500, "Игровые" },
                    { 6, 9, "254450351_images_20259144261.jpg", "AMD", 18, "GDDR5", "RX 520", 2300, "Профессиональные" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VideoCarsList",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VideoCarsList",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VideoCarsList",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VideoCarsList",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VideoCarsList",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VideoCarsList",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AddColumn<string>(
                name: "Chip",
                table: "VideoCarsList",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

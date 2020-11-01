using Microsoft.EntityFrameworkCore.Migrations;

namespace PC_shop.Migrations
{
    public partial class seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HddList",
                columns: new[] { "Id", "Capacity", "CategoryId", "Images", "Make", "Name", "Price", "ReadSpeed", "WriteSpeed" },
                values: new object[,]
                {
                    { 1, 500, 2, "230651827_images_19012954021.jpg; 230651827_images_19012954345.jpg", "Western Digital", "Ultrastar DC HC520 500 Gb", 300, 550, 450 },
                    { 2, 1000, 2, "western_digital_wd10ezex_images_7029060.jpg", "Western Digital", "Ultrastar DC HC520 1 Tb", 600, 350, 450 },
                    { 3, 960, 2, "silicon_power_armor_a60_1tb_sp010tbphda60s3k_images_117061555.jpg; silicon_power_armor_a60_1tb_sp010tbphda60s3k_images_117061620.jpg", "Silicon Power", "Armor A60 1 Tb", 250, 420, 320 },
                    { 4, 1500, 2, "silicon_power_armor_a60_1tb_sp010tbphda60s3k_images_117061555.jpg; silicon_power_armor_a60_1tb_sp010tbphda60s3k_images_117061620.jpg", "Silicon Power", "Armor A60 1.5 Tb", 350, 470, 540 },
                    { 5, 750, 2, "seagate_st2000nm0008_images_5655527064.jpg; seagate_st2000nm0008_images_5655528408.jpg; seagate_st2000nm0008_images_5655529608.jpg; seagate_st2000nm0008_images_5655532688.jpg", "Seagate", "Exos 7E2 512N", 800, 340, 560 },
                    { 6, 1000, 2, "apacer_ap1tbac630t_1_images_2913243303.jpg; apacer_ap1tbac630t_1_images_2913243975.jpg", "Apacer", "AC630 1TB", 950, 410, 400 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HddList",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HddList",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HddList",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HddList",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HddList",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HddList",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}

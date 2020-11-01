using Microsoft.EntityFrameworkCore.Migrations;

namespace PC_shop.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CpuList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    CountOfCores = table.Column<int>(nullable: false),
                    CountOfThreads = table.Column<int>(nullable: false),
                    Graphics = table.Column<string>(nullable: true),
                    TechProcess = table.Column<int>(nullable: false),
                    Images = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CpuList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HddList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ReadSpeed = table.Column<int>(nullable: false),
                    WriteSpeed = table.Column<int>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    Images = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HddList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SsdList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    ReadSpeed = table.Column<int>(nullable: false),
                    WriteSpeed = table.Column<int>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    Images = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SsdList", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CpuList",
                columns: new[] { "Id", "CategoryId", "CountOfCores", "CountOfThreads", "Graphics", "Images", "Make", "Name", "Price", "TechProcess" },
                values: new object[,]
                {
                    { 1, 1, 10, 20, "Intel UHD Graphics 630", "intel_bx8070110900k_images_18036977635.jpg; intel_bx8070110900k_images_18036977713.jpg; intel_bx8070110900k_images_18036977791.jpg", "Intel", "intel x10", 500, 14 },
                    { 2, 1, 8, 16, "Intel UHD Graphics 630", "intel_bx8070110700k_images_18036978979.jpg; intel_bx8070110700k_images_18036979117.jpg; intel_bx8070110700k_images_18036979195.jpg", "Intel", "intel x8", 1200, 14 },
                    { 3, 1, 6, 6, "Нет", "intel_core_i5_9400f_bx80684i59400f_images_10930275039.jpg; intel_core_i5_9400f_bx80684i59400f_images_10930275525.jpg; intel_core_i5_9400f_bx80684i59400f_images_10930277979.jpg", "Intel", "intel x6", 900, 14 },
                    { 4, 1, 8, 16, "Нет", "copy_amd_ryzen_7_3800x_5d175dc657832_images_12764982409.jpg; copy_amd_ryzen_7_3800x_5d175dc657832_images_12764983147.jpg; copy_amd_ryzen_7_3800x_5d175dc657832_images_12764983759.jpg", "AMD", "AMD x8", 400, 7 },
                    { 5, 1, 6, 12, "Нет", "copy_amd_ryzen_5_3600x_5f100787c16dd_images_19179571645.jpg; copy_amd_ryzen_5_3600x_5f100787c16dd_images_19179572233.jpg; copy_amd_ryzen_5_3600x_5f100787c16dd_images_19179572899.jpg", "AMD", "AMD x6", 1500, 7 },
                    { 6, 1, 4, 8, "Нет", "amd_ryzen_3_3100_images_18001372357.jpg; amd_ryzen_3_3100_images_18001299481.jpg; amd_ryzen_3_3100_images_18001298797.jpg; amd_ryzen_3_3100_images_18001298413.jpg; amd_ryzen_3_3100_images_18001297993.jpg; amd_ryzen_3_3100_images_18001297027.jpg", "AMD", "AMD x4", 1600, 7 }
                });

            migrationBuilder.InsertData(
                table: "SsdList",
                columns: new[] { "Id", "Capacity", "CategoryId", "Images", "Make", "Name", "Price", "ReadSpeed", "WriteSpeed" },
                values: new object[,]
                {
                    { 1, 256, 8, "copy_samsung_mz_76e250bw_5a6b2ed990cae_images_2697298199.jpg; samsung_mz_76e500bw_images_2697297479.jpg; samsung_mz_76e500bw_images_2697389775.jpg", "Samsung", "Samsung 256", 700, 550, 450 },
                    { 2, 512, 8, "kingston_kc_s44240_6f_images_10624101638.jpg; kingston_kc_s44240_6f_images_10624115984.jpg; kingston_kc_s44240_6f_images_10624109906.jpg", "Kingston", "Kingston 512", 300, 1550, 1450 },
                    { 3, 960, 8, "kingston_sa400s37_240g_images_1869202190.jpg;copy_kingston_sa400s37_480g_58b165d6202d1_images_1869202346.jpg;kingston_sa400s37_240g_images_1869202580.jpg", "Kingston", "Kingston 960", 850, 500, 400 },
                    { 4, 960, 8, "intel_ssdsc2kg480g801_images_12425177618.jpg;intel_ssdsc2kg480g801_images_12425176232.jpg;intel_ssdsc2kg480g801_images_12425174594.jpg", "Intel", "Intel 960", 1400, 500, 400 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CpuList");

            migrationBuilder.DropTable(
                name: "HddList");

            migrationBuilder.DropTable(
                name: "SsdList");
        }
    }
}

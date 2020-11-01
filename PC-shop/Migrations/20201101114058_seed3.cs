using Microsoft.EntityFrameworkCore.Migrations;

namespace PC_shop.Migrations
{
    public partial class seed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KeyboardList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Interface = table.Column<string>(nullable: true),
                    ConnectionType = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    Images = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyboardList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonitorList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Size = table.Column<decimal>(nullable: false),
                    Frequency = table.Column<int>(nullable: false),
                    Resolution = table.Column<string>(nullable: true),
                    MatrixType = table.Column<string>(nullable: true),
                    AspectRatio = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    Images = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitorList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotherBoardList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Socket = table.Column<string>(nullable: true),
                    FormFactor = table.Column<string>(nullable: true),
                    MemorySupport = table.Column<string>(nullable: true),
                    IntegratedVideoCard = table.Column<bool>(nullable: false),
                    VideoExit = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    Images = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotherBoardList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MouseList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ConnectionType = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Interface = table.Column<string>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    Images = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MouseList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RamList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Capacity = table.Column<int>(nullable: false),
                    MemoryType = table.Column<string>(nullable: true),
                    Frequency = table.Column<int>(nullable: false),
                    Purpose = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    Images = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RamList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoCarsList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Chip = table.Column<string>(nullable: true),
                    MemorySize = table.Column<int>(nullable: false),
                    MemoryType = table.Column<string>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    Images = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoCarsList", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "KeyboardList",
                columns: new[] { "Id", "CategoryId", "ConnectionType", "Images", "Interface", "Make", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 1, 3, "проводная", "razer_rz03_02741500_r3r1_images_17214343196.jpg; razer_rz03_02741500_r3r1_images_17214344281.jpg; razer_rz03_02741500_r3r1_images_17214347305.jpg", "PS/2", "Razer", "Cynosa Lite", 300, "механическая" },
                    { 2, 3, "беспроводная", "msi_ds4100_gk_images_1881348038.jpg; msi_ds4100_gk_images_1881348506.jpg; msi_ds4100_gk_images_1881348584.jpg", "USB", "MSI", "Interceptor DS4100", 600, "мембранная" },
                    { 3, 3, "комбинированная", "real_el_8700_gaming_backlit_black_images_2265988904.jpg; real_el_8700_gaming_backlit_black_images_2265989056.jpg; real_el_8700_gaming_backlit_black_images_2265989264.jpg; real_el_8700_gaming_backlit_black_images_2265989528.jpg", "Bluetooth", "Real-El", "8700 Backlit", 250, "механическая" },
                    { 4, 3, "проводная", "logitech_920_008019_images_20106386466.jpg; logitech_920_008019_images_20106386531.jpg; logitech_920_008019_images_20106386661.jpg", "Bluetooth", "Logitech", "G910 Orion Spectrum", 350, "механическая" },
                    { 5, 3, "комбинированная", "logitech_920_009417_images_20106372101.jpg; logitech_920_009417_images_20106372231.jpg; logitech_920_009417_images_20106372361.jpg", "USB", "Logitech", "MX Keys Wireless", 800, "мембранная" },
                    { 6, 3, "комбинированная", "hyperx_hx_kb5me2_ru_images_10289690949.jpg; hyperx_hx_kb5me2_ru_images_10289691489.jpg; hyperx_hx_kb5me2_ru_images_10289692101.jpg; hyperx_hx_kb5me2_ru_images_10289692833.jpg", "USB", "HyperX", "Alloy Core RGB Membrane", 950, "мембранная" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KeyboardList");

            migrationBuilder.DropTable(
                name: "MonitorList");

            migrationBuilder.DropTable(
                name: "MotherBoardList");

            migrationBuilder.DropTable(
                name: "MouseList");

            migrationBuilder.DropTable(
                name: "RamList");

            migrationBuilder.DropTable(
                name: "VideoCarsList");
        }
    }
}

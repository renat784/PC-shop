using Microsoft.EntityFrameworkCore.Migrations;

namespace PC_shop.Migrations
{
    public partial class seed_monitor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Size",
                table: "MonitorList",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "MonitorList",
                columns: new[] { "Id", "AspectRatio", "CategoryId", "Frequency", "Images", "Make", "MatrixType", "Name", "Price", "Resolution", "Size" },
                values: new object[,]
                {
                    { 1, "16:9", 4, 50, "samsung_s22f350f_images_17676384529.jpg; samsung_s22f350f_images_17676390007.jpg; samsung_s22f350f_images_17676449473.jpg", "Samsung", "TN", "W2020", 700, "4650 x 2080", 22.0 },
                    { 2, "16:9", 4, 150, "samsung_lc27rg50fqixci_images_18139211713.jpg; samsung_lc27rg50fqixci_images_18547319707.jpg; samsung_lc27rg50fqixci_images_17984381143.jpg", "Samsung", "TN", "W2025", 300, "8500/1920", 28.0 },
                    { 3, "16:9", 4, 100, "lenovo_61cakat1ua_images_11956157922.jpg; lenovo_61cakat1ua_images_11956158414.jpg; lenovo_61cakat1ua_images_11956159122.jpg", "LENOVO", "IPS", "SN4420", 500, "2150/1920", 28.0 },
                    { 4, "16:10", 4, 150, "hp_1fh47aa_images_2533452095.png; hp_1fh47aa_images_2533451839.png; hp_1fh47aa_images_2533452199.png", "HP", "IPS", "TN2210", 1700, "2150/1920", 17.0 },
                    { 5, "16:9", 4, 50, "copy_dell_210_atuz_5e1c7fb9d85ee_images_16305254652.jpg; copy_dell_210_atuz_5e1c7fb9d85ee_images_16305254743.jpg; copy_dell_210_atuz_5e1c7fb9d85ee_images_16305254841.jpg", "Dell", "IPS", "G1223", 750, "1920/1080", 17.0 },
                    { 6, "16:10", 4, 60, "dell_210_apwu_images_10482430088.jpg; dell_210_apwu_images_10482431150.jpg; dell_210_apwu_images_10482432434.jpg", "Dell", "IPS", "Super S1", 700, "4550/1920", 15.4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MonitorList",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "Size",
                table: "MonitorList",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}

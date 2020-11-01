using Microsoft.EntityFrameworkCore.Migrations;

namespace PC_shop.Migrations
{
    public partial class seed_mouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MouseList",
                columns: new[] { "Id", "CategoryId", "ConnectionType", "Images", "Interface", "Make", "Name", "Price", "Purpose", "Size" },
                values: new object[,]
                {
                    { 1, 6, "Проводное", "asus_90mp01j0_b0ua00_images_14376695289.jpg; asus_90mp01j0_b0ua00_images_14376697641.jpg; asus_90mp01j0_b0ua00_images_14376698425.jpg; asus_90mp01j0_b0ua00_images_14376700784.jpg", "PS/2", "Asus", "A55", 50, "Игровая", "Большая" },
                    { 2, 6, "Беспроводное", "asus_90mp01e0_b0ua00_images_17777271403.jpg; asus_90mp01e0_b0ua00_images_17777271727.jpg", "USB", "Asus", "Asus force", 110, "Игровая", "Маленькая" },
                    { 3, 6, "Беспроводное", "defender_52990_images_16514293517.png; defender_52990_images_16514293909.png; defender_52990_images_16514294553.png", "USB", "Defender", "D200-i", 70, "Игровая", "Средняя" },
                    { 4, 6, "Проводное", "defender_52160_images_4221349240.jpg; defender_52160_images_4221349336.jpg; defender_52160_images_4221349488.jpg", "USB", "Defender", "D100-i", 200, "Обычные", "Большая" },
                    { 5, 6, "Проводное", "logitech_910_005632_images_14833040413.jpg; logitech_910_005632_images_14833040889.jpg; logitech_910_005632_images_14833041155.jpg; logitech_910_005632_images_14833041491.jpg", "Bluetooth", "Logitech", "L450 Pro", 150, "Обычные", "Средняя" },
                    { 6, 6, "Проводное", "razer_rz01_02540100_r3m1_images_8362600534.jpg; razer_rz01_02540100_r3m1_images_8362601926.jpg; razer_rz01_02540100_r3m1_images_8362602382.jpg", "Bluetooth", "Razer", "R220", 100, "Обычные", "Большая" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MouseList",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MouseList",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MouseList",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MouseList",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MouseList",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MouseList",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}

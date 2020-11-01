using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PC_shop.Models;

namespace PC_shop.Data
{
   
    public class PC_shopContext : DbContext
    {
        public PC_shopContext (DbContextOptions<PC_shopContext> options)
            : base(options)
        {
        }
        //public DbSet<Category> Categories { get; set; }
        public DbSet<Cpu> CpuList { get; set; }
        public DbSet<Hdd> HddList { get; set; }
        public DbSet<Keyboard> KeyboardList { get; set; }
        public DbSet<Monitor> MonitorList { get; set; }
        public DbSet<MotherBoard> MotherBoardList { get; set; }
        public DbSet<Mouse> MouseList { get; set; }
        public DbSet<Ram> RamList { get; set; }
        public DbSet<Ssd> SsdList { get; set; }
        public DbSet<VideoCard> VideoCarsList { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cpu>().HasData(new List<Cpu>()
            {
                new Cpu()
                {
                    Id = 1,
                    CategoryId = (int)Category.Cpu,
                    Name = "intel x10",
                    Make = "Intel",
                    Price = 500,
                    CountOfCores = 10,
                    Graphics = "Intel UHD Graphics 630",
                    CountOfThreads = 20,
                    TechProcess = 14,
                    Images = "intel_bx8070110900k_images_18036977635.jpg; intel_bx8070110900k_images_18036977713.jpg; intel_bx8070110900k_images_18036977791.jpg",
                },

                new Cpu()
                {
                    Id = 2,
                    CategoryId = (int)Category.Cpu,
                    Name = "intel x8",
                    Make = "Intel",
                    Price = 1200,
                    CountOfCores = 8,
                    Graphics = "Intel UHD Graphics 630",
                    CountOfThreads = 16,
                    TechProcess = 14,
                    Images = "intel_bx8070110700k_images_18036978979.jpg; intel_bx8070110700k_images_18036979117.jpg; intel_bx8070110700k_images_18036979195.jpg",
                },

                new Cpu()
                {
                    Id = 3,
                    CategoryId = (int)Category.Cpu,
                    Name = "intel x6",
                    Make = "Intel",
                    Price = 900,
                    CountOfCores = 6,
                    Graphics = "Нет",
                    CountOfThreads = 6,
                    TechProcess = 14,
                    Images = "intel_core_i5_9400f_bx80684i59400f_images_10930275039.jpg; intel_core_i5_9400f_bx80684i59400f_images_10930275525.jpg; intel_core_i5_9400f_bx80684i59400f_images_10930277979.jpg",
                },


                new Cpu()
                {
                    Id = 4,
                    CategoryId = (int)Category.Cpu,
                    Name = "AMD x8",
                    Make = "AMD",
                    Price = 400,
                    CountOfCores = 8,
                    Graphics = "Нет",
                    CountOfThreads = 16,
                    TechProcess = 7,
                    Images = "copy_amd_ryzen_7_3800x_5d175dc657832_images_12764982409.jpg; copy_amd_ryzen_7_3800x_5d175dc657832_images_12764983147.jpg; copy_amd_ryzen_7_3800x_5d175dc657832_images_12764983759.jpg",
                },

                new Cpu()
                {
                    Id = 5,
                    CategoryId = (int)Category.Cpu,
                    Name = "AMD x6",
                    Make = "AMD",
                    Price = 1500,
                    CountOfCores = 6,
                    Graphics = "Нет",
                    CountOfThreads = 12,
                    TechProcess = 7,
                    Images = "copy_amd_ryzen_5_3600x_5f100787c16dd_images_19179571645.jpg; copy_amd_ryzen_5_3600x_5f100787c16dd_images_19179572233.jpg; copy_amd_ryzen_5_3600x_5f100787c16dd_images_19179572899.jpg",
                },

                new Cpu()
                {
                    Id = 6,
                    CategoryId = (int)Category.Cpu,
                    Name = "AMD x4",
                    Make = "AMD",
                    Price = 1600,
                    CountOfCores = 4,
                    Graphics = "Нет",
                    CountOfThreads = 8,
                    TechProcess = 7,
                    Images = "amd_ryzen_3_3100_images_18001372357.jpg; amd_ryzen_3_3100_images_18001299481.jpg; amd_ryzen_3_3100_images_18001298797.jpg; amd_ryzen_3_3100_images_18001298413.jpg; amd_ryzen_3_3100_images_18001297993.jpg; amd_ryzen_3_3100_images_18001297027.jpg",
                },
            });
            modelBuilder.Entity<Hdd>().HasData(new List<Hdd>()
            {
                new Hdd()
                {
                    Id = 1,
                    CategoryId = (int)Category.Hdd,
                    Name = "Ultrastar DC HC520 500 Gb",
                    Price = 300,
                    Capacity = 500,
                    Make = "Western Digital",
                    ReadSpeed = 550,
                    WriteSpeed = 450,
                    Images = "230651827_images_19012954021.jpg; 230651827_images_19012954345.jpg"
                },
                new Hdd()
                {
                    Id = 2,
                    CategoryId = (int)Category.Hdd,
                    Name = "Ultrastar DC HC520 1 Tb",
                    Price = 600,
                    Capacity = 1000,
                    Make = "Western Digital",
                    ReadSpeed = 350,
                    WriteSpeed = 450,
                    Images = "western_digital_wd10ezex_images_7029060.jpg"
                },
                new Hdd()
                {
                    Id = 3,
                    CategoryId = (int)Category.Hdd,
                    Name = "Armor A60 1 Tb",
                    Price = 250,
                    Capacity = 960,
                    Make = "Silicon Power",
                    ReadSpeed = 420,
                    WriteSpeed = 320,
                    Images = "silicon_power_armor_a60_1tb_sp010tbphda60s3k_images_117061555.jpg; silicon_power_armor_a60_1tb_sp010tbphda60s3k_images_117061620.jpg"
                },
                new Hdd()
                {
                    Id = 4,
                    CategoryId = (int)Category.Hdd,
                    Name = "Armor A60 1.5 Tb",
                    Price = 350,
                    Capacity = 1500,
                    Make = "Silicon Power",
                    ReadSpeed = 470,
                    WriteSpeed = 540,
                    Images = "silicon_power_armor_a60_1tb_sp010tbphda60s3k_images_117061555.jpg; silicon_power_armor_a60_1tb_sp010tbphda60s3k_images_117061620.jpg"
                },
                new Hdd()
                {
                    Id = 5,
                    CategoryId = (int)Category.Hdd,
                    Name = "Exos 7E2 512N",
                    Price = 800,
                    Capacity = 750,
                    Make = "Seagate",
                    ReadSpeed = 340,
                    WriteSpeed = 560,
                    Images = "seagate_st2000nm0008_images_5655527064.jpg; seagate_st2000nm0008_images_5655528408.jpg; seagate_st2000nm0008_images_5655529608.jpg; seagate_st2000nm0008_images_5655532688.jpg"
                },
                new Hdd()
                {
                    Id = 6,
                    CategoryId = (int)Category.Hdd,
                    Name = "AC630 1TB",
                    Price = 950,
                    Capacity = 1000,
                    Make = "Apacer",
                    ReadSpeed = 410,
                    WriteSpeed = 400,
                    Images = "apacer_ap1tbac630t_1_images_2913243303.jpg; apacer_ap1tbac630t_1_images_2913243975.jpg"
                },

            });
            modelBuilder.Entity<Keyboard>().HasData(new List<Keyboard>()
            {
                new Keyboard()
                {
                    Id = 1,
                    CategoryId = (int)Category.Keyboard,
                    Name = "Cynosa Lite",
                    Price = 300,
                    Make = "Razer",
                    ConnectionType = "проводная",
                    Interface = "PS/2",
                    Type = "механическая",
                    Images = "razer_rz03_02741500_r3r1_images_17214343196.jpg; razer_rz03_02741500_r3r1_images_17214344281.jpg; razer_rz03_02741500_r3r1_images_17214347305.jpg"
                },
                new Keyboard()
                {
                    Id = 2,
                    CategoryId = (int)Category.Keyboard,
                    Name = "Interceptor DS4100",
                    Price = 600,
                    Type = "мембранная",
                    ConnectionType = "беспроводная",
                    Interface = "USB",
                    Make = "MSI",
                    Images = "msi_ds4100_gk_images_1881348038.jpg; msi_ds4100_gk_images_1881348506.jpg; msi_ds4100_gk_images_1881348584.jpg"
                },
                new Keyboard()
                {
                    Id = 3,
                    CategoryId = (int)Category.Keyboard,
                    Name = "8700 Backlit",
                    Price = 250,
                    Type = "механическая",
                    Interface = "Bluetooth",
                    ConnectionType = "комбинированная",
                    Make = "Real-El",
                    Images = "real_el_8700_gaming_backlit_black_images_2265988904.jpg; real_el_8700_gaming_backlit_black_images_2265989056.jpg; real_el_8700_gaming_backlit_black_images_2265989264.jpg; real_el_8700_gaming_backlit_black_images_2265989528.jpg"
                },
                new Keyboard()
                {
                    Id = 4,
                    CategoryId = (int)Category.Keyboard,
                    Name = "G910 Orion Spectrum",
                    Price = 350,
                    Type = "механическая",
                    Interface = "Bluetooth",
                    ConnectionType = "проводная",
                    Make = "Logitech",
                    Images = "logitech_920_008019_images_20106386466.jpg; logitech_920_008019_images_20106386531.jpg; logitech_920_008019_images_20106386661.jpg"
                },
                new Keyboard()
                {
                    Id = 5,
                    CategoryId = (int)Category.Keyboard,
                    Name = "MX Keys Wireless",
                    Price = 800,
                    Type = "мембранная",
                    Make = "Logitech",
                    Interface = "USB",
                    ConnectionType = "комбинированная",
                    Images = "logitech_920_009417_images_20106372101.jpg; logitech_920_009417_images_20106372231.jpg; logitech_920_009417_images_20106372361.jpg"
                },
                new Keyboard()
                {
                    Id = 6,
                    CategoryId = (int)Category.Keyboard,
                    Name = "Alloy Core RGB Membrane",
                    Price = 950,
                    Type = "мембранная",
                    Interface = "USB",
                    Make = "HyperX",
                    ConnectionType = "комбинированная",
                    Images = "hyperx_hx_kb5me2_ru_images_10289690949.jpg; hyperx_hx_kb5me2_ru_images_10289691489.jpg; hyperx_hx_kb5me2_ru_images_10289692101.jpg; hyperx_hx_kb5me2_ru_images_10289692833.jpg"
                },

            });
            modelBuilder.Entity<Monitor>().HasData(new List<Monitor>()
            {
                new Monitor()
                {
                    Id = 1,
                    CategoryId = (int)Category.Monitor,
                    Name = "W2020",
                    AspectRatio = "16:9",
                    Frequency = 50,
                    MatrixType = "TN",
                    Resolution = "4650 x 2080",
                    Size = 22,
                    Price = 700,
                    Make = "Samsung",
                    Images = "samsung_s22f350f_images_17676384529.jpg; samsung_s22f350f_images_17676390007.jpg; samsung_s22f350f_images_17676449473.jpg"
                },

                new Monitor()
                {
                    Id = 2,
                    CategoryId = (int)Category.Monitor,
                    Name = "W2025",
                    AspectRatio = "16:9",
                    Frequency = 150,
                    MatrixType = "TN",
                    Resolution = "8500/1920",
                    Size = 28,
                    Price = 300,
                    Make = "Samsung",
                    Images = "samsung_lc27rg50fqixci_images_18139211713.jpg; samsung_lc27rg50fqixci_images_18547319707.jpg; samsung_lc27rg50fqixci_images_17984381143.jpg"
                },
                new Monitor()
                {
                    Id = 3,
                    CategoryId = (int)Category.Monitor,
                    Name = "SN4420",
                    AspectRatio = "16:9",
                    Frequency = 100,
                    MatrixType = "IPS",
                    Resolution = "2150/1920",
                    Size = 28,
                    Price = 500,
                    Make = "LENOVO",
                    Images = "lenovo_61cakat1ua_images_11956157922.jpg; lenovo_61cakat1ua_images_11956158414.jpg; lenovo_61cakat1ua_images_11956159122.jpg"
                },
                new Monitor()
                {
                    Id = 4,
                    CategoryId = (int)Category.Monitor,
                    Name = "TN2210",
                    AspectRatio = "16:10",
                    Frequency = 150,
                    MatrixType = "IPS",
                    Resolution = "2150/1920",
                    Size = 17,
                    Price = 1700,
                    Make = "HP",
                    Images = "hp_1fh47aa_images_2533452095.png; hp_1fh47aa_images_2533451839.png; hp_1fh47aa_images_2533452199.png"
                },
                new Monitor()
                {
                    Id = 5,
                    CategoryId = (int)Category.Monitor,
                    Name = "G1223",
                    AspectRatio = "16:9",
                    Frequency = 50,
                    MatrixType = "IPS",
                    Resolution = "1920/1080",
                    Size = 17,
                    Price = 750,
                    Make = "Dell",
                    Images = "copy_dell_210_atuz_5e1c7fb9d85ee_images_16305254652.jpg; copy_dell_210_atuz_5e1c7fb9d85ee_images_16305254743.jpg; copy_dell_210_atuz_5e1c7fb9d85ee_images_16305254841.jpg"
                },
                new Monitor()
                {
                    Id = 6,
                    CategoryId = (int)Category.Monitor,
                    Name = "Super S1",
                    AspectRatio = "16:10",
                    Frequency = 60,
                    MatrixType = "IPS",
                    Resolution = "4550/1920",
                    Size = 15.4,
                    Price = 700,
                    Make = "Dell",
                    Images = "dell_210_apwu_images_10482430088.jpg; dell_210_apwu_images_10482431150.jpg; dell_210_apwu_images_10482432434.jpg"
                },

            });
            modelBuilder.Entity<MotherBoard>().HasData(new List<MotherBoard>()
            {
                new MotherBoard()
                {
                    Id = 1,
                    CategoryId = (int)Category.Motherboard,
                    Name = "I-PRO20",
                    Make = "Asus",
                    FormFactor = "ATX",
                    IntegratedVideoCard = true,
                    MemorySupport = "1866",
                    Socket = "Socket 1567",
                    VideoExit = "DVI",
                    Price = 800,
                    Images = "asus_tuf_z390_plus_gaming_wi_fi_images_7904477637.jpg; asus_tuf_z390_plus_gaming_wi_fi_images_7904478087.jpg; asus_tuf_z390_plus_gaming_wi_fi_images_7904478861.jpg"
                },
                new MotherBoard()
                {
                    Id = 2,
                    CategoryId = (int)Category.Motherboard,
                    Name = "A99-50",
                    Make = "Acer",
                    FormFactor = "ATX",
                    IntegratedVideoCard = false,
                    MemorySupport = "1333",
                    Socket = "Socket 1366",
                    VideoExit = "DVI",
                    Price = 1700,
                    Images = "218526139_images_18467982511.jpg"
                },
                new MotherBoard()
                {
                    Id = 3,
                    CategoryId = (int)Category.Motherboard,
                    Name = "G990 MAX",
                    Make = "Gigabyte",
                    FormFactor = "MicroATX",
                    IntegratedVideoCard = true,
                    MemorySupport = "1333",
                    Socket = "Socket 1150",
                    VideoExit = "HDMI",
                    Price = 1100,
                    Images = "gigabyte_x399_aorus_pro_images_10802381841.jpg; gigabyte_x399_aorus_pro_images_10802960535.jpg; gigabyte_x399_aorus_pro_images_10802383041.jpg"
                },
                new MotherBoard()
                {
                    Id = 4,
                    CategoryId = (int)Category.Motherboard,
                    Name = "H450i",
                    Make = "HP",
                    FormFactor = "MicroATX",
                    IntegratedVideoCard = true,
                    MemorySupport = "1333",
                    Socket = "Socket 1150",
                    VideoExit = "HDMI",
                    Price = 700,
                    Images = "191457449_images_17158409871.jpg"
                },
                new MotherBoard()
                {
                    Id = 5,
                    CategoryId = (int)Category.Motherboard,
                    Name = "Q88 Pro",
                    Make = "MSI",
                    FormFactor = "EATX",
                    IntegratedVideoCard = false,
                    MemorySupport = "1600",
                    Socket = "Socket 1155",
                    VideoExit = "DisplayPort",
                    Price = 500,
                    Images = "msi_b450_tomahawk_max_images_13269008218.jpg; msi_b450_tomahawk_max_images_13269009592.jpg; msi_b450_tomahawk_max_images_13269011554.jpg"
                },
                new MotherBoard()
                {
                    Id = 6,
                    CategoryId = (int)Category.Motherboard,
                    Name = "I-350ZX",
                    Make = "Intel",
                    FormFactor = "MiniITX",
                    IntegratedVideoCard = false,
                    MemorySupport = "1600",
                    Socket = "Socket 1155",
                    VideoExit = "D-Sub",
                    Price = 300,
                    Images = "240799177_images_19528687813.jpg"
                },



            });
            modelBuilder.Entity<Mouse>().HasData(new List<Mouse>()
            {
                new Mouse()
                {
                    Id = 1,
                    CategoryId = (int)Category.Mouse,
                    Name = "A55",
                    ConnectionType = "Проводное",
                    Interface = "PS/2",
                    Purpose = "Игровая",
                    Size = "Большая",
                    Price = 50,
                    Make = "Asus",
                    Images = "asus_90mp01j0_b0ua00_images_14376695289.jpg; asus_90mp01j0_b0ua00_images_14376697641.jpg; asus_90mp01j0_b0ua00_images_14376698425.jpg; asus_90mp01j0_b0ua00_images_14376700784.jpg"
                },
                new Mouse()
                {
                    Id = 2,
                    CategoryId = (int)Category.Mouse,
                    Name = "Asus force",
                    ConnectionType = "Беспроводное",
                    Interface = "USB",
                    Purpose = "Игровая",
                    Size = "Маленькая",
                    Price = 110,
                    Make = "Asus",
                    Images = "asus_90mp01e0_b0ua00_images_17777271403.jpg; asus_90mp01e0_b0ua00_images_17777271727.jpg"
                },
                new Mouse()
                {
                    Id = 3,
                    CategoryId = (int)Category.Mouse,
                    Name = "D200-i",
                    ConnectionType = "Беспроводное",
                    Interface = "USB",
                    Purpose = "Игровая",
                    Size = "Средняя",
                    Price = 70,
                    Make = "Defender",
                    Images = "defender_52990_images_16514293517.png; defender_52990_images_16514293909.png; defender_52990_images_16514294553.png"
                },
                new Mouse()
                {
                    Id = 4,
                    CategoryId = (int)Category.Mouse,
                    Name = "D100-i",
                    ConnectionType = "Проводное",
                    Interface = "USB",
                    Purpose = "Обычные",
                    Size = "Большая",
                    Price = 200,
                    Make = "Defender",
                    Images = "defender_52160_images_4221349240.jpg; defender_52160_images_4221349336.jpg; defender_52160_images_4221349488.jpg"
                },
                new Mouse()
                {
                    Id = 5,
                    CategoryId = (int)Category.Mouse,
                    Name = "L450 Pro",
                    ConnectionType = "Проводное",
                    Interface = "Bluetooth",
                    Purpose = "Обычные",
                    Size = "Средняя",
                    Price = 150,
                    Make = "Logitech",
                    Images = "logitech_910_005632_images_14833040413.jpg; logitech_910_005632_images_14833040889.jpg; logitech_910_005632_images_14833041155.jpg; logitech_910_005632_images_14833041491.jpg"
                },
                new Mouse()
                {
                    Id = 6,
                    CategoryId = (int)Category.Mouse,
                    Name = "R220",
                    ConnectionType = "Проводное",
                    Interface = "Bluetooth",
                    Purpose = "Обычные",
                    Size = "Большая",
                    Price = 100,
                    Make = "Razer",
                    Images = "razer_rz01_02540100_r3m1_images_8362600534.jpg; razer_rz01_02540100_r3m1_images_8362601926.jpg; razer_rz01_02540100_r3m1_images_8362602382.jpg"
                },


            });
            modelBuilder.Entity<Ssd>().HasData(new List<Ssd>()
            {
                new Ssd()
                {
                    Id = 1,
                    CategoryId = (int)Category.Ssd,
                    Name = "Samsung 256",
                    Price = 700,
                    Capacity = 256,
                    Make = "Samsung",
                    ReadSpeed = 550,
                    WriteSpeed = 450,
                    Images = "copy_samsung_mz_76e250bw_5a6b2ed990cae_images_2697298199.jpg; samsung_mz_76e500bw_images_2697297479.jpg; samsung_mz_76e500bw_images_2697389775.jpg"
                },
                new Ssd()
                {
                    Id = 2,
                    CategoryId = (int)Category.Ssd,
                    Name = "Kingston 512",
                    Price = 300,
                    Capacity = 512,
                    Make = "Kingston",
                    ReadSpeed = 1550,
                    WriteSpeed = 1450,
                    Images = "kingston_kc_s44240_6f_images_10624101638.jpg; kingston_kc_s44240_6f_images_10624115984.jpg; kingston_kc_s44240_6f_images_10624109906.jpg"
                },
                new Ssd()
                {
                    Id = 3,
                    CategoryId = (int)Category.Ssd,
                    Name = "Kingston 960",
                    Price = 850,
                    Capacity = 960,
                    Make = "Kingston",
                    ReadSpeed = 500,
                    WriteSpeed = 400,
                    Images = "kingston_sa400s37_240g_images_1869202190.jpg;copy_kingston_sa400s37_480g_58b165d6202d1_images_1869202346.jpg;kingston_sa400s37_240g_images_1869202580.jpg"
                },
                new Ssd()
                {
                    Id = 4,
                    CategoryId = (int)Category.Ssd,
                    Name = "Intel 960",
                    Price = 1400,
                    Capacity = 960,
                    Make = "Intel",
                    ReadSpeed = 500,
                    WriteSpeed = 400,
                    Images = "intel_ssdsc2kg480g801_images_12425177618.jpg;intel_ssdsc2kg480g801_images_12425176232.jpg;intel_ssdsc2kg480g801_images_12425174594.jpg"
                },

            });
            modelBuilder.Entity<Ram>().HasData(new List<Ram>()
            {
                new Ram()
                {
                    Id = 1,
                    CategoryId = (int)Category.Ram,
                    Name = "i4580",
                    Price = 1100,
                    Capacity = 32,
                    Purpose = "Для настольных компьютеров",
                    Frequency = 2400,
                    MemoryType = "DDR-4",
                    Make = "Intel",
                    Images = "kingston_kvr24n17s6_4_images_11390403828.jpg"
                },
                new Ram()
                {
                    Id = 2,
                    CategoryId = (int)Category.Ram,
                    Name = "i80S",
                    Price = 800,
                    Capacity = 16,
                    Purpose = "Для настольных компьютеров",
                    Frequency = 2133,
                    MemoryType = "DDR-4",
                    Make = "Intel",
                    Images = "kingston_kvr24n17d8_16_images_1735238670.jpg; kingston_kvr24n17d8_16_images_1735238817.jpg"
                },
                new Ram()
                {
                    Id = 3,
                    CategoryId = (int)Category.Ram,
                    Name = "k50-34",
                    Price = 1350,
                    Capacity = 32,
                    Purpose = "Для настольных компьютеров",
                    Frequency = 2400,
                    MemoryType = "DDR-4",
                    Make = "Kingston",
                    Images = "kingston_kvr13n9s8_4_images_6975524.jpg"
                },
                new Ram()
                {
                    Id = 4,
                    CategoryId = (int)Category.Ram,
                    Name = "m32-3",
                    Price = 300,
                    Capacity = 8,
                    Purpose = "Для ноутбуков",
                    Frequency = 2133,
                    MemoryType = "SODIMM DDR4",
                    Make = "Intel",
                    Images = "kingston_kvr16ls11_8_images_83231304.jpg"
                },
                new Ram()
                {
                    Id = 5,
                    CategoryId = (int)Category.Ram,
                    Name = "D80 Pro 5",
                    Price = 2100,
                    Capacity = 32,
                    Purpose = "Для настольных компьютеров",
                    Frequency = 4400,
                    MemoryType = "DDR-4",
                    Make = "Kingston",
                    Images = "kingston_kvr26n19s6_4_images_8900628336.jpg"
                },
                new Ram()
                {
                    Id = 6,
                    CategoryId = (int)Category.Ram,
                    Name = "Fury Black",
                    Price = 6100,
                    Capacity = 128,
                    Purpose = "Для серверов",
                    Frequency = 5400,
                    MemoryType = "DDR-4",
                    Make = "HyperX",
                    Images = "copy_hyperx_hx430c16fb3k4_128_5e1f564adf3a8_images_16349879680.jpg"
                },


            });
            modelBuilder.Entity<VideoCard>().HasData(new List<VideoCard>()
            {
                new VideoCard()
                {
                    Id = 1,
                    CategoryId = (int)Category.VideoCard,
                    Name = "GT 2510z",
                    MemorySize = 4,
                    Price = 400,
                    Purpose = "Обычные",
                    MemoryType = "GDDR5",
                    Make = "NVIDEA",
                    Images = "234123103_images_19199193643.jpg; 234123103_images_19199194105.jpg; 234123103_images_19199194591.jpg"
                },
                new VideoCard()
                {
                    Id = 2,
                    CategoryId = (int)Category.VideoCard,
                    Name = "GTX 780",
                    MemorySize = 4,
                    Price = 450,
                    Purpose = "Обычные",
                    MemoryType = "GDDR4",
                    Make = "NVIDEA",
                    Images = "234128197_images_19198957285.jpg; 234128197_images_19198957045.jpg"
                },
                new VideoCard()
                {
                    Id = 3,
                    CategoryId = (int)Category.VideoCard,
                    Name = "MX 250 Super",
                    MemorySize = 12,
                    Price = 450,
                    Purpose = "Игровые",
                    MemoryType = "GDDR5",
                    Make = "MSI",
                    Images = "msi_gtx_1660_super_ventus_xs_oc_images_14954879417.png; msi_gtx_1660_super_ventus_xs_oc_images_14954879774.png; msi_gtx_1660_super_ventus_xs_oc_images_14954880467.png"
                },
                new VideoCard()
                {
                    Id = 4,
                    CategoryId = (int)Category.VideoCard,
                    Name = "M1 Hero",
                    MemorySize = 10,
                    Price = 600,
                    Purpose = "Игровые",
                    MemoryType = "GDDR5",
                    Make = "MSI",
                    Images = "msi_rtx_3070_ventus_2x_oc_images_20161643341.png; msi_rtx_3070_ventus_2x_oc_images_20161644331.png; msi_rtx_3070_ventus_2x_oc_images_20161645501.png"
                },
                new VideoCard()
                {
                    Id = 5,
                    CategoryId = (int)Category.VideoCard,
                    Name = "RXi 500",
                    MemorySize = 8,
                    Price = 500,
                    Purpose = "Игровые",
                    MemoryType = "GDDR5",
                    Make = "AMD",
                    Images = "116106877_images_13695811621.jpg"
                },
                new VideoCard()
                {
                    Id = 6,
                    CategoryId = (int)Category.VideoCard,
                    Name = "RX 520",
                    MemorySize = 18,
                    Price = 2300,
                    Purpose = "Профессиональные",
                    MemoryType = "GDDR5",
                    Make = "AMD",
                    Images = "254450351_images_20259144261.jpg"
                },


            });

        }

        
    }
}

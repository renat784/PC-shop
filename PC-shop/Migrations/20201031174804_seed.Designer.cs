﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PC_shop.Data;

namespace PC_shop.Migrations
{
    [DbContext(typeof(PC_shopContext))]
    [Migration("20201031174804_seed")]
    partial class seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PC_shop.Models.Cpu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CountOfCores")
                        .HasColumnType("int");

                    b.Property<int>("CountOfThreads")
                        .HasColumnType("int");

                    b.Property<string>("Graphics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("TechProcess")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CpuList");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CountOfCores = 10,
                            CountOfThreads = 20,
                            Graphics = "Intel UHD Graphics 630",
                            Images = "intel_bx8070110900k_images_18036977635.jpg; intel_bx8070110900k_images_18036977713.jpg; intel_bx8070110900k_images_18036977791.jpg",
                            Make = "Intel",
                            Name = "intel x10",
                            Price = 500,
                            TechProcess = 14
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CountOfCores = 8,
                            CountOfThreads = 16,
                            Graphics = "Intel UHD Graphics 630",
                            Images = "intel_bx8070110700k_images_18036978979.jpg; intel_bx8070110700k_images_18036979117.jpg; intel_bx8070110700k_images_18036979195.jpg",
                            Make = "Intel",
                            Name = "intel x8",
                            Price = 1200,
                            TechProcess = 14
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CountOfCores = 6,
                            CountOfThreads = 6,
                            Graphics = "Нет",
                            Images = "intel_core_i5_9400f_bx80684i59400f_images_10930275039.jpg; intel_core_i5_9400f_bx80684i59400f_images_10930275525.jpg; intel_core_i5_9400f_bx80684i59400f_images_10930277979.jpg",
                            Make = "Intel",
                            Name = "intel x6",
                            Price = 900,
                            TechProcess = 14
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            CountOfCores = 8,
                            CountOfThreads = 16,
                            Graphics = "Нет",
                            Images = "copy_amd_ryzen_7_3800x_5d175dc657832_images_12764982409.jpg; copy_amd_ryzen_7_3800x_5d175dc657832_images_12764983147.jpg; copy_amd_ryzen_7_3800x_5d175dc657832_images_12764983759.jpg",
                            Make = "AMD",
                            Name = "AMD x8",
                            Price = 400,
                            TechProcess = 7
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            CountOfCores = 6,
                            CountOfThreads = 12,
                            Graphics = "Нет",
                            Images = "copy_amd_ryzen_5_3600x_5f100787c16dd_images_19179571645.jpg; copy_amd_ryzen_5_3600x_5f100787c16dd_images_19179572233.jpg; copy_amd_ryzen_5_3600x_5f100787c16dd_images_19179572899.jpg",
                            Make = "AMD",
                            Name = "AMD x6",
                            Price = 1500,
                            TechProcess = 7
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            CountOfCores = 4,
                            CountOfThreads = 8,
                            Graphics = "Нет",
                            Images = "amd_ryzen_3_3100_images_18001372357.jpg; amd_ryzen_3_3100_images_18001299481.jpg; amd_ryzen_3_3100_images_18001298797.jpg; amd_ryzen_3_3100_images_18001298413.jpg; amd_ryzen_3_3100_images_18001297993.jpg; amd_ryzen_3_3100_images_18001297027.jpg",
                            Make = "AMD",
                            Name = "AMD x4",
                            Price = 1600,
                            TechProcess = 7
                        });
                });

            modelBuilder.Entity("PC_shop.Models.Hdd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ReadSpeed")
                        .HasColumnType("int");

                    b.Property<int>("WriteSpeed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HddList");
                });

            modelBuilder.Entity("PC_shop.Models.Ssd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ReadSpeed")
                        .HasColumnType("int");

                    b.Property<int>("WriteSpeed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SsdList");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 256,
                            CategoryId = 8,
                            Images = "copy_samsung_mz_76e250bw_5a6b2ed990cae_images_2697298199.jpg; samsung_mz_76e500bw_images_2697297479.jpg; samsung_mz_76e500bw_images_2697389775.jpg",
                            Make = "Samsung",
                            Name = "Samsung 256",
                            Price = 700,
                            ReadSpeed = 550,
                            WriteSpeed = 450
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 512,
                            CategoryId = 8,
                            Images = "kingston_kc_s44240_6f_images_10624101638.jpg; kingston_kc_s44240_6f_images_10624115984.jpg; kingston_kc_s44240_6f_images_10624109906.jpg",
                            Make = "Kingston",
                            Name = "Kingston 512",
                            Price = 300,
                            ReadSpeed = 1550,
                            WriteSpeed = 1450
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 960,
                            CategoryId = 8,
                            Images = "kingston_sa400s37_240g_images_1869202190.jpg;copy_kingston_sa400s37_480g_58b165d6202d1_images_1869202346.jpg;kingston_sa400s37_240g_images_1869202580.jpg",
                            Make = "Kingston",
                            Name = "Kingston 960",
                            Price = 850,
                            ReadSpeed = 500,
                            WriteSpeed = 400
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 960,
                            CategoryId = 8,
                            Images = "intel_ssdsc2kg480g801_images_12425177618.jpg;intel_ssdsc2kg480g801_images_12425176232.jpg;intel_ssdsc2kg480g801_images_12425174594.jpg",
                            Make = "Intel",
                            Name = "Intel 960",
                            Price = 1400,
                            ReadSpeed = 500,
                            WriteSpeed = 400
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
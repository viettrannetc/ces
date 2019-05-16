﻿// <auto-generated />
using CES.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CES.Database.Migrations
{
    [DbContext(typeof(CesContext))]
    [Migration("20190516094933_add-route-data")]
    partial class addroutedata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CES.Database.Models.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new { Id = 1L, Code = "DKO", Name = "DE KANARISKE OER" },
                        new { Id = 2L, Code = "TUN", Name = "TUNIS'" },
                        new { Id = 3L, Code = "SUA", Name = "SUAKIN" },
                        new { Id = 4L, Code = "TAN", Name = "TANGER" },
                        new { Id = 5L, Code = "CAI", Name = "CAIRO" },
                        new { Id = 6L, Code = "KAG", Name = "KAP GUARDAFUI" },
                        new { Id = 7L, Code = "AMA", Name = "AMATAVE" },
                        new { Id = 8L, Code = "MOC", Name = "MOCAMBIQUE" },
                        new { Id = 9L, Code = "KAM", Name = "KAP ST.MARIE" },
                        new { Id = 10L, Code = "KAP", Name = "KAPSTADEN" },
                        new { Id = 11L, Code = "HVA", Name = "HVALBUGTEN" },
                        new { Id = 12L, Code = "HEL", Name = "ST. HELENA" },
                        new { Id = 13L, Code = "SLA", Name = "SLAVEKYSTEN" },
                        new { Id = 14L, Code = "GUL", Name = "GULDKYSTEN" },
                        new { Id = 15L, Code = "SIL", Name = "SIERRA LEONE" },
                        new { Id = 16L, Code = "DAK", Name = "DAKAR" },
                        new { Id = 17L, Code = "MAR", Name = "MARRAKESH" },
                        new { Id = 18L, Code = "SAH", Name = "SAHARA" },
                        new { Id = 19L, Code = "TIM", Name = "TIMBUKTU" },
                        new { Id = 20L, Code = "WAD", Name = "WADAI" },
                        new { Id = 21L, Code = "DAR", Name = "DARFUR" },
                        new { Id = 22L, Code = "CON", Name = "CONGO" },
                        new { Id = 23L, Code = "OMD", Name = "OMDURMAN" },
                        new { Id = 24L, Code = "TRI", Name = "TRIPOLI" },
                        new { Id = 25L, Code = "LUA", Name = "LUANDA" },
                        new { Id = 26L, Code = "KAB", Name = "KABALO" },
                        new { Id = 27L, Code = "VIF", Name = "VICTORIAFALDENE" },
                        new { Id = 28L, Code = "BAG", Name = "BAHREL GHAZAL" },
                        new { Id = 29L, Code = "ADA", Name = "ADDIS ABEBA" },
                        new { Id = 30L, Code = "VIS", Name = "VICTORIASOEN" },
                        new { Id = 31L, Code = "ZAN", Name = "ZANZIBAR" },
                        new { Id = 32L, Code = "DRA", Name = "DRAGEBJERGET" }
                    );
                });

            modelBuilder.Entity("CES.Database.Models.Route", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Destination");

                    b.Property<int>("NumberOfSegments");

                    b.Property<string>("Start");

                    b.HasKey("Id");

                    b.ToTable("Routes");

                    b.HasData(
                        new { Id = 1L, Destination = "TRI", NumberOfSegments = 3, Start = "TUN" },
                        new { Id = 2L, Destination = "TAN", NumberOfSegments = 5, Start = "TUN" },
                        new { Id = 3L, Destination = "ADA", NumberOfSegments = 3, Start = "SUA" },
                        new { Id = 4L, Destination = "DAR", NumberOfSegments = 4, Start = "SUA" },
                        new { Id = 5L, Destination = "TUN", NumberOfSegments = 5, Start = "TAN" },
                        new { Id = 6L, Destination = "SAH", NumberOfSegments = 5, Start = "TAN" },
                        new { Id = 7L, Destination = "MAR", NumberOfSegments = 2, Start = "TAN" },
                        new { Id = 8L, Destination = "OMD", NumberOfSegments = 4, Start = "CAI" },
                        new { Id = 9L, Destination = "ADA", NumberOfSegments = 3, Start = "KAG" },
                        new { Id = 10L, Destination = "ZAN", NumberOfSegments = 6, Start = "KAG" },
                        new { Id = 11L, Destination = "ZAN", NumberOfSegments = 3, Start = "MOC" },
                        new { Id = 12L, Destination = "VIS", NumberOfSegments = 6, Start = "MOC" },
                        new { Id = 13L, Destination = "DRA", NumberOfSegments = 4, Start = "MOC" },
                        new { Id = 14L, Destination = "VIF", NumberOfSegments = 5, Start = "MOC" },
                        new { Id = 15L, Destination = "LUA", NumberOfSegments = 10, Start = "MOC" },
                        new { Id = 16L, Destination = "HVA", NumberOfSegments = 4, Start = "KAP" },
                        new { Id = 17L, Destination = "VIF", NumberOfSegments = 4, Start = "HVA" },
                        new { Id = 18L, Destination = "CON", NumberOfSegments = 5, Start = "SLA" },
                        new { Id = 19L, Destination = "DAR", NumberOfSegments = 7, Start = "SLA" },
                        new { Id = 20L, Destination = "WAD", NumberOfSegments = 7, Start = "SLA" },
                        new { Id = 21L, Destination = "TIM", NumberOfSegments = 5, Start = "SLA" },
                        new { Id = 22L, Destination = "TIM", NumberOfSegments = 4, Start = "GUL" },
                        new { Id = 23L, Destination = "SIL", NumberOfSegments = 5, Start = "GUL" },
                        new { Id = 24L, Destination = "GUL", NumberOfSegments = 5, Start = "SIL" },
                        new { Id = 25L, Destination = "TIM", NumberOfSegments = 5, Start = "SIL" },
                        new { Id = 26L, Destination = "DAK", NumberOfSegments = 4, Start = "SIL" },
                        new { Id = 27L, Destination = "SIL", NumberOfSegments = 4, Start = "DAK" },
                        new { Id = 28L, Destination = "MAR", NumberOfSegments = 8, Start = "DAK" },
                        new { Id = 29L, Destination = "DAK", NumberOfSegments = 8, Start = "MAR" },
                        new { Id = 30L, Destination = "TAN", NumberOfSegments = 2, Start = "MAR" },
                        new { Id = 31L, Destination = "SAH", NumberOfSegments = 5, Start = "MAR" },
                        new { Id = 32L, Destination = "TAN", NumberOfSegments = 5, Start = "SAH" },
                        new { Id = 33L, Destination = "MAR", NumberOfSegments = 5, Start = "SAH" },
                        new { Id = 34L, Destination = "DAR", NumberOfSegments = 8, Start = "SAH" },
                        new { Id = 35L, Destination = "SLA", NumberOfSegments = 5, Start = "TIM" },
                        new { Id = 36L, Destination = "GUL", NumberOfSegments = 4, Start = "TIM" },
                        new { Id = 37L, Destination = "SIL", NumberOfSegments = 5, Start = "TIM" },
                        new { Id = 38L, Destination = "DAR", NumberOfSegments = 4, Start = "WAD" },
                        new { Id = 39L, Destination = "CON", NumberOfSegments = 6, Start = "WAD" },
                        new { Id = 40L, Destination = "SLA", NumberOfSegments = 7, Start = "WAD" },
                        new { Id = 41L, Destination = "BAG", NumberOfSegments = 2, Start = "DAR" },
                        new { Id = 42L, Destination = "SUA", NumberOfSegments = 4, Start = "DAR" },
                        new { Id = 43L, Destination = "OMD", NumberOfSegments = 3, Start = "DAR" },
                        new { Id = 44L, Destination = "SAH", NumberOfSegments = 8, Start = "DAR" },
                        new { Id = 45L, Destination = "WAD", NumberOfSegments = 4, Start = "DAR" },
                        new { Id = 46L, Destination = "CON", NumberOfSegments = 6, Start = "DAR" },
                        new { Id = 47L, Destination = "SLA", NumberOfSegments = 7, Start = "DAR" },
                        new { Id = 48L, Destination = "LUA", NumberOfSegments = 3, Start = "CON" },
                        new { Id = 49L, Destination = "DAR", NumberOfSegments = 6, Start = "CON" },
                        new { Id = 50L, Destination = "WAI", NumberOfSegments = 6, Start = "CON" },
                        new { Id = 51L, Destination = "SLA", NumberOfSegments = 5, Start = "CON" },
                        new { Id = 52L, Destination = "CAI", NumberOfSegments = 4, Start = "OMD" },
                        new { Id = 53L, Destination = "DAR", NumberOfSegments = 3, Start = "OMD" },
                        new { Id = 54L, Destination = "TRI", NumberOfSegments = 6, Start = "OMD" },
                        new { Id = 55L, Destination = "TUN", NumberOfSegments = 3, Start = "TRI" },
                        new { Id = 56L, Destination = "OMD", NumberOfSegments = 6, Start = "TRI" },
                        new { Id = 57L, Destination = "CON", NumberOfSegments = 3, Start = "LUA" },
                        new { Id = 58L, Destination = "KAB", NumberOfSegments = 0, Start = "LUA" },
                        new { Id = 59L, Destination = "MOC", NumberOfSegments = 10, Start = "LUA" },
                        new { Id = 60L, Destination = "VIF", NumberOfSegments = 11, Start = "LUA" },
                        new { Id = 61L, Destination = "DRA", NumberOfSegments = 11, Start = "LUA" },
                        new { Id = 62L, Destination = "VIS", NumberOfSegments = 4, Start = "KAB" },
                        new { Id = 63L, Destination = "LUA", NumberOfSegments = 4, Start = "KAB" },
                        new { Id = 64L, Destination = "HVA", NumberOfSegments = 4, Start = "VIF" },
                        new { Id = 65L, Destination = "DRA", NumberOfSegments = 3, Start = "VIF" },
                        new { Id = 66L, Destination = "MOC", NumberOfSegments = 5, Start = "VIF" },
                        new { Id = 67L, Destination = "LUA", NumberOfSegments = 11, Start = "VIF" },
                        new { Id = 68L, Destination = "VIS", NumberOfSegments = 2, Start = "BAG" },
                        new { Id = 69L, Destination = "DAR", NumberOfSegments = 2, Start = "BAG" },
                        new { Id = 70L, Destination = "VIS", NumberOfSegments = 3, Start = "ADA" },
                        new { Id = 71L, Destination = "KAG", NumberOfSegments = 3, Start = "ADA" },
                        new { Id = 72L, Destination = "SUA", NumberOfSegments = 3, Start = "ADA" },
                        new { Id = 73L, Destination = "KAB", NumberOfSegments = 4, Start = "VIS" },
                        new { Id = 74L, Destination = "BAG", NumberOfSegments = 2, Start = "VIS" },
                        new { Id = 75L, Destination = "ADA", NumberOfSegments = 3, Start = "VIS" },
                        new { Id = 76L, Destination = "MOC", NumberOfSegments = 6, Start = "VIS" },
                        new { Id = 77L, Destination = "ZAN", NumberOfSegments = 5, Start = "VIS" },
                        new { Id = 78L, Destination = "KAG", NumberOfSegments = 6, Start = "ZAN" },
                        new { Id = 79L, Destination = "MOC", NumberOfSegments = 3, Start = "ZAN" },
                        new { Id = 80L, Destination = "VIS", NumberOfSegments = 5, Start = "ZAN" },
                        new { Id = 81L, Destination = "VIF", NumberOfSegments = 3, Start = "DRA" },
                        new { Id = 82L, Destination = "MOC", NumberOfSegments = 4, Start = "DRA" },
                        new { Id = 83L, Destination = "LUA", NumberOfSegments = 11, Start = "DRA" }
                    );
                });

            modelBuilder.Entity("CES.Database.Models.RouteConfiguration", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaxiumWeight");

                    b.Property<string>("PriceBetweenTwoSegments");

                    b.HasKey("Id");

                    b.ToTable("RouteConfigurations");
                });

            modelBuilder.Entity("CES.Database.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using BoatWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoatWebApi.Migrations
{
    [DbContext(typeof(GpsDataContext))]
    partial class GpsDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoatWebApi.Models.GpsBoatData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Angle");

                    b.Property<double>("Latitude");

                    b.Property<double>("Lontitude");

                    b.Property<int>("Satellite");

                    b.HasKey("Id");

                    b.ToTable("GpsBoatDatas");
                });

            modelBuilder.Entity("BoatWebApi.Models.GpsData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Latitude");

                    b.Property<double>("Lontitude");

                    b.Property<int>("Satellite");

                    b.HasKey("Id");

                    b.ToTable("GpsDatas");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using API_SwitchBack.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_SwitchBack.Migrations
{
    [DbContext(typeof(SwitchbackAPIDbContext))]
    [Migration("20190416230019_initial32")]
    partial class initial32
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API_SwitchBack.Models.Trail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ascent");

                    b.Property<string>("ConditionDate");

                    b.Property<string>("ConditionDetails");

                    b.Property<string>("ConditionStatus");

                    b.Property<int>("Descent");

                    b.Property<string>("Difficulty");

                    b.Property<int>("High");

                    b.Property<string>("ImgMedium");

                    b.Property<string>("ImgSmall");

                    b.Property<string>("ImgSmallMed");

                    b.Property<string>("ImgSqSmall");

                    b.Property<float>("Latitude");

                    b.Property<float>("Length");

                    b.Property<string>("Location");

                    b.Property<float>("Longitude");

                    b.Property<int>("Low");

                    b.Property<string>("Name");

                    b.Property<int>("StarVotes");

                    b.Property<float>("Stars");

                    b.Property<string>("Summary");

                    b.Property<string>("Type");

                    b.Property<string>("Url");

                    b.HasKey("ID");

                    b.ToTable("Trail");
                });

            modelBuilder.Entity("API_SwitchBack.Models.UserRatings", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Rating");

                    b.Property<int?>("TrailID");

                    b.Property<int>("TrailInfoID");

                    b.HasKey("ID");

                    b.HasIndex("TrailID");

                    b.ToTable("UserRatings");
                });

            modelBuilder.Entity("API_SwitchBack.Models.UserRatings", b =>
                {
                    b.HasOne("API_SwitchBack.Models.Trail", "Trail")
                        .WithMany("UserRatings")
                        .HasForeignKey("TrailID");
                });
#pragma warning restore 612, 618
        }
    }
}
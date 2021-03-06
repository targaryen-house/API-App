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
    [Migration("20190419155348_initial")]
    partial class initial
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
                    b.Property<int>("TrailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiID");

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

                    b.Property<double>("Latitude");

                    b.Property<double>("Length");

                    b.Property<string>("Location");

                    b.Property<double>("Longitude");

                    b.Property<int>("Low");

                    b.Property<string>("Name");

                    b.Property<int>("StarVotes");

                    b.Property<double>("Stars");

                    b.Property<string>("Summary");

                    b.Property<string>("Type");

                    b.Property<string>("Url");

                    b.HasKey("TrailID");

                    b.ToTable("Trail");

                    b.HasData(
                        new
                        {
                            TrailID = 1,
                            ApiID = 7005406,
                            Ascent = 1619,
                            ConditionDate = "2019-03-28 11:05:03",
                            ConditionDetails = "Dry",
                            ConditionStatus = "All Clear",
                            Descent = -1618,
                            Difficulty = "blue",
                            High = 1807,
                            ImgMedium = "https://cdn-files.apstatic.com/hike/7004771_medium_1554310760.jpg",
                            ImgSmall = "https://cdn-files.apstatic.com/hike/7004771_small_1554310760.jpg",
                            ImgSmallMed = "https://cdn-files.apstatic.com/hike/7004771_smallMed_1554310760.jpg",
                            ImgSqSmall = "https://cdn-files.apstatic.com/hike/7004771_sqsmall_1554310760.jpg",
                            Latitude = 47.499899999999997,
                            Length = 3.8999999999999999,
                            Location = "Issaquah, Washington",
                            Longitude = -122.0211,
                            Low = 188,
                            Name = "Poo Poo Point via Chirico Trail",
                            StarVotes = 50,
                            Stars = 4.2999999999999998,
                            Summary = "A great place for a picnic and watching paragliders!",
                            Type = "Featured Hike",
                            Url = "https://www.hikingproject.com/trail/7005406/poo-poo-point-via-chirico-trail"
                        },
                        new
                        {
                            TrailID = 2,
                            ApiID = 7027304,
                            Ascent = 690,
                            ConditionDate = "2019-04-02 00:00:00",
                            ConditionDetails = "Mostly Dry: Snow free",
                            ConditionStatus = "All Clear",
                            Descent = -676,
                            Difficulty = "greenBlue",
                            High = 1278,
                            ImgMedium = "https://cdn-files.apstatic.com/hike/7031970_medium_1554932139.jpg",
                            ImgSmall = "https://cdn-files.apstatic.com/hike/7031970_small_1554932139.jpg",
                            ImgSmallMed = "https://cdn-files.apstatic.com/hike/7031970_smallMed_1554932139.jpg",
                            ImgSqSmall = "https://cdn-files.apstatic.com/hike/7031970_sqsmall_1554932139.jpg",
                            Latitude = 47.534599999999998,
                            Length = 5.0999999999999996,
                            Location = "Newcastle, Washington",
                            Longitude = -122.12860000000001,
                            Low = 676,
                            Name = "Cougar Mountain Red Town Loop",
                            StarVotes = 24,
                            Stars = 4.4000000000000004,
                            Summary = "This well-maintained rolling loop is a treat just minutes from Seattle.",
                            Type = "Featured Hike",
                            Url = "https://www.hikingproject.com/trail/7027304/cougar-mountain-red-town-loop"
                        });
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

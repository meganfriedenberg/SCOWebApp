﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SCOWebApp.Models;

namespace SCOWebApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210803233341_NotesAddedOnTrip")]
    partial class NotesAddedOnTrip
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SCOWebApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Camping"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Backpacking"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Surfing"
                        });
                });

            modelBuilder.Entity("SCOWebApp.Models.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsTripOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeatherConditions")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TripId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            TripId = 1,
                            CategoryId = 1,
                            ImageThumbnailUrl = "http://www.californiasbestbeaches.com/photos6/morro_strand_beach.jpg",
                            ImageURL = "https://cdn.pixabay.com/photo/2010/12/17/00/26/morro-rock-3687_960_720.jpg",
                            IsTripOfTheWeek = true,
                            LongDescription = "Join us for a weekend long trip exploring San Luis Obispo and swimming at the beach. ",
                            Name = "Morro Strand State Beach",
                            Price = 40.95m,
                            ShortDescription = "Beach camping near SLO"
                        },
                        new
                        {
                            TripId = 2,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://uscband.usc.edu/wp-content/uploads/2021/08/littlelakesValley.jpg",
                            ImageURL = "https://boundtoexplore.com/wp-content/uploads/2019/03/little-lakes-valley-hike-6.jpg",
                            IsTripOfTheWeek = false,
                            LongDescription = "A great introduction into backpacking through an overnighter through this upper Mammoth valley. Only 1500 ft ascension to Gem Lakes.",
                            Name = "Little Lakes Valley",
                            Price = 65.95m,
                            ShortDescription = "Easy backpacking through the eastern Sierras"
                        },
                        new
                        {
                            TripId = 3,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://malibuluxuryrealty.com/wp-content/uploads/2016/08/5036486731_5e873ab83b_b-1024x683.jpg",
                            ImageURL = "https://d14fqx6aetz9ka.cloudfront.net/wp-content/uploads/2018/05/30134747/Malibu-Spot-Check-50-1560x1016.jpg",
                            IsTripOfTheWeek = true,
                            LongDescription = "Whether you've never surfed or are an intermediate, join us for longboarding over small waves.",
                            Name = "Malibu Surfing",
                            Price = 10.95m,
                            ShortDescription = "Friday afternoon easy waves"
                        },
                        new
                        {
                            TripId = 7,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/19/a4/e4/8b/lodgepole-campground.jpg?w=900&h=-1&s=1",
                            ImageURL = "https://cdn.pixabay.com/photo/2010/12/17/00/26/morro-rock-3687_960_720.jpg",
                            IsTripOfTheWeek = false,
                            LongDescription = "Long day hikes with evening board games will be your 3 day holiday weekend at this giant forest!",
                            Name = "Sequoia National Park Camping",
                            Price = 55.95m,
                            ShortDescription = "2 day camping at Lodgepole"
                        },
                        new
                        {
                            TripId = 4,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://prd-wret.s3.us-west-2.amazonaws.com/assets/palladium/production/s3fs-public/styles/full_width/public/thumbnails/image/a39.jpg",
                            ImageURL = "https://live.staticflickr.com/4224/34706522321_18d3d6b5db_b.jpg",
                            IsTripOfTheWeek = true,
                            LongDescription = "Backpack a far distance in a day and a half, but jump in multiple hot springs along the way!",
                            Name = "Joshua Tree Hot Springs Hopping",
                            Price = 35.95m,
                            ShortDescription = "Overnight backpacking to hot springs"
                        },
                        new
                        {
                            TripId = 5,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://beaches.lacounty.gov/wp-content/uploads/2016/10/Dockweiler_1.jpg",
                            ImageURL = "https://www.visitmarinadelrey.com/wp-content/gallery/dockweiler-beach/dockweiler-entrance-sign.jpg",
                            IsTripOfTheWeek = false,
                            LongDescription = "Chill out Satuday by cooking kabobs or surfing Dockweiler State Beach's beautiful blue waves",
                            Name = "Dockweiler Surfing",
                            Price = 15.95m,
                            ShortDescription = "BBQ on the beach with medium waves"
                        },
                        new
                        {
                            TripId = 6,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://lh3.googleusercontent.com/proxy/dGKYwoJzBhUjDK65mFz8PwqvgMXz8K58CeC0jsEfpN8K8uxh1Y9mKfvcluIlk4awoNWfSDr-1nYRDVigVgC8cSZIuvxA9T-_yYXTH2PfgTvAxDVLgJAvu1q2zZRsq9R4lo6VDA0Hgu8",
                            ImageURL = "https://www.nps.gov/chis/planyourvisit/images/960-IMG_5362.jpg?maxwidth=650&autorotate=false",
                            IsTripOfTheWeek = false,
                            LongDescription = "Don't want to get too dirty on the weekends? Backpack out to a rented shelter for some more casual camping.",
                            Name = "Channel Islands Backpack Glamping",
                            Price = 40.95m,
                            ShortDescription = "Backpack one night on the main island to a rented structure"
                        });
                });

            modelBuilder.Entity("SCOWebApp.Models.Trip", b =>
                {
                    b.HasOne("SCOWebApp.Models.Category", "Category")
                        .WithMany("Trips")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

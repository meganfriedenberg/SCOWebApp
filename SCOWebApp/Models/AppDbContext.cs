using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCOWebApp.Models
{
    public class AppDbContext : DbContext //middleman between code and the sql database
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Trip> Trips { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Camping" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Backpacking" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Surfing" });

            //seed trips

            modelBuilder.Entity<Trip>().HasData(new Trip
            {
                TripId = 1,
                Name = "Morro Strand State Beach",
                Price = 40.95M,
                ShortDescription = "Beach camping near SLO",
                LongDescription = "Join us for a weekend long trip exploring San Luis Obispo and swimming at the beach. ",
                CategoryId = 1,
                ImageURL = "https://cdn.pixabay.com/photo/2010/12/17/00/26/morro-rock-3687_960_720.jpg",
                IsTripOfTheWeek = true,
                ImageThumbnailUrl = "http://www.californiasbestbeaches.com/photos6/morro_strand_beach.jpg"

            });

            modelBuilder.Entity<Trip>().HasData(new Trip
            {
                TripId = 2,
                Name = "Little Lakes Valley",
                Price = 65.95M,
                ShortDescription = "Easy backpacking through the eastern Sierras",
                LongDescription = "A great introduction into backpacking through an overnighter through this upper Mammoth valley. Only 1500 ft ascension to Gem Lakes.",
                CategoryId = 2,
                ImageURL = "https://boundtoexplore.com/wp-content/uploads/2019/03/little-lakes-valley-hike-6.jpg",
                IsTripOfTheWeek = false,
                ImageThumbnailUrl = "https://uscband.usc.edu/wp-content/uploads/2021/08/littlelakesValley.jpg"

             });

            modelBuilder.Entity<Trip>().HasData(new Trip
            {
                TripId = 3,
                Name = "Malibu Surfing",
                Price = 10.95M,
                ShortDescription = "Friday afternoon easy waves",
                LongDescription = "Whether you've never surfed or are an intermediate, join us for longboarding over small waves.",
                CategoryId = 3,
                ImageURL = "https://d14fqx6aetz9ka.cloudfront.net/wp-content/uploads/2018/05/30134747/Malibu-Spot-Check-50-1560x1016.jpg",
                IsTripOfTheWeek = true,
                ImageThumbnailUrl = "https://malibuluxuryrealty.com/wp-content/uploads/2016/08/5036486731_5e873ab83b_b-1024x683.jpg"

            });

            modelBuilder.Entity<Trip>().HasData(new Trip
            {
                TripId = 7,
                Name = "Sequoia National Park Camping",
                Price = 55.95M,
                ShortDescription = "2 day camping at Lodgepole",
                LongDescription = "Long day hikes with evening board games will be your 3 day holiday weekend at this giant forest!",
                CategoryId = 1,
                ImageURL = "https://cdn.pixabay.com/photo/2010/12/17/00/26/morro-rock-3687_960_720.jpg",
                IsTripOfTheWeek = false,
                ImageThumbnailUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/19/a4/e4/8b/lodgepole-campground.jpg?w=900&h=-1&s=1"

            });

            modelBuilder.Entity<Trip>().HasData(new Trip
            {
                TripId = 4,
                Name = "Joshua Tree Hot Springs Hopping",
                Price = 35.95M,
                ShortDescription = "Overnight backpacking to hot springs",
                LongDescription = "Backpack a far distance in a day and a half, but jump in multiple hot springs along the way!",
                CategoryId = 2,
                ImageURL = "https://live.staticflickr.com/4224/34706522321_18d3d6b5db_b.jpg",
                IsTripOfTheWeek = true,
                ImageThumbnailUrl = "https://prd-wret.s3.us-west-2.amazonaws.com/assets/palladium/production/s3fs-public/styles/full_width/public/thumbnails/image/a39.jpg"

            });

            modelBuilder.Entity<Trip>().HasData(new Trip
            {
                TripId = 5,
                Name = "Dockweiler Surfing",
                Price = 15.95M,
                ShortDescription = "BBQ on the beach with medium waves",
                LongDescription = "Chill out Satuday by cooking kabobs or surfing Dockweiler State Beach's beautiful blue waves",
                CategoryId = 3,
                ImageURL = "https://www.visitmarinadelrey.com/wp-content/gallery/dockweiler-beach/dockweiler-entrance-sign.jpg",
                IsTripOfTheWeek = false,
                ImageThumbnailUrl = "https://beaches.lacounty.gov/wp-content/uploads/2016/10/Dockweiler_1.jpg"

            });


            modelBuilder.Entity<Trip>().HasData(new Trip
            {
                TripId = 6,
                Name = "Channel Islands Backpack Glamping",
                Price = 40.95M,
                ShortDescription = "Backpack one night on the main island to a rented structure",
                LongDescription = "Don't want to get too dirty on the weekends? Backpack out to a rented shelter for some more casual camping.",
                CategoryId = 2,
                ImageURL = "https://www.nps.gov/chis/planyourvisit/images/960-IMG_5362.jpg?maxwidth=650&autorotate=false",
                IsTripOfTheWeek = false,
                ImageThumbnailUrl = "https://lh3.googleusercontent.com/proxy/dGKYwoJzBhUjDK65mFz8PwqvgMXz8K58CeC0jsEfpN8K8uxh1Y9mKfvcluIlk4awoNWfSDr-1nYRDVigVgC8cSZIuvxA9T-_yYXTH2PfgTvAxDVLgJAvu1q2zZRsq9R4lo6VDA0Hgu8"

            });
        }
    }

}

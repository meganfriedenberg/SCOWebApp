using Microsoft.EntityFrameworkCore.Migrations;

namespace SCOWebApp.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Camping", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Backpacking", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Surfing", null });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "CategoryId", "ImageThumbnailUrl", "ImageURL", "IsTripOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription", "WeatherConditions" },
                values: new object[,]
                {
                    { 1, 1, "http://www.californiasbestbeaches.com/photos6/morro_strand_beach.jpg", "https://cdn.pixabay.com/photo/2010/12/17/00/26/morro-rock-3687_960_720.jpg", true, "Join us for a weekend long trip exploring San Luis Obispo and swimming at the beach. ", "Morro Strand State Beach", 40.95m, "Beach camping near San Luis Obispo", null },
                    { 4, 1, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/19/a4/e4/8b/lodgepole-campground.jpg?w=900&h=-1&s=1", "https://cdn.pixabay.com/photo/2010/12/17/00/26/morro-rock-3687_960_720.jpg", false, "Long day hikes with evening board games will be your 3 day holiday weekend at this giant forest!", "Sequoia National Park Camping", 55.95m, "2 day camping at Lodgepole Campground", null },
                    { 2, 2, "https://uscband.usc.edu/wp-content/uploads/2021/08/littlelakesValley.jpg", "https://boundtoexplore.com/wp-content/uploads/2019/03/little-lakes-valley-hike-6.jpg", false, "A great introduction into backpacking through an overnighter through this upper Mammoth valley. Only 1500 ft ascension to Gem Lakes.", "Little Lakes Valley", 65.95m, "Easy backpacking through the eastern Sierras", null },
                    { 5, 2, "https://prd-wret.s3.us-west-2.amazonaws.com/assets/palladium/production/s3fs-public/styles/full_width/public/thumbnails/image/a39.jpg", "https://live.staticflickr.com/4224/34706522321_18d3d6b5db_b.jpg", true, "Backpack a far distance in a day and a half, but jump in multiple hot springs along the way!", "Joshua Tree Hot Springs Hopping", 35.95m, "One night adventure backpacking hot spring to hot spring", null },
                    { 7, 2, "https://lh3.googleusercontent.com/proxy/dGKYwoJzBhUjDK65mFz8PwqvgMXz8K58CeC0jsEfpN8K8uxh1Y9mKfvcluIlk4awoNWfSDr-1nYRDVigVgC8cSZIuvxA9T-_yYXTH2PfgTvAxDVLgJAvu1q2zZRsq9R4lo6VDA0Hgu8", "https://www.nps.gov/chis/planyourvisit/images/960-IMG_5362.jpg?maxwidth=650&autorotate=false", false, "Don't want to get too dirty on the weekends? Backpack out to a rented shelter for some more casual camping.", "Channel Islands Backpack Glamping", 40.95m, "Backpack one night on the main island to a rented structure", null },
                    { 3, 3, "https://malibuluxuryrealty.com/wp-content/uploads/2016/08/5036486731_5e873ab83b_b-1024x683.jpg", "https://d14fqx6aetz9ka.cloudfront.net/wp-content/uploads/2018/05/30134747/Malibu-Spot-Check-50-1560x1016.jpg", true, "Whether you've never surfed or are an intermediate, join us for longboarding over small waves.", "Malibu Surfing", 10.95m, "Friday afternoon easy waves", null },
                    { 6, 3, "https://beaches.lacounty.gov/wp-content/uploads/2016/10/Dockweiler_1.jpg", "https://www.visitmarinadelrey.com/wp-content/gallery/dockweiler-beach/dockweiler-entrance-sign.jpg", false, "Chill out Satuday by cooking kabobs or surfing Dockweiler State Beach's beautiful blue waves", "Dockweiler Surfing", 15.95m, "BBQ on the beach with medium waves", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}

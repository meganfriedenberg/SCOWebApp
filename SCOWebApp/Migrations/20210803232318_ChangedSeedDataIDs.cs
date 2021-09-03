using Microsoft.EntityFrameworkCore.Migrations;

namespace SCOWebApp.Migrations
{
    public partial class ChangedSeedDataIDs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 4,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "ImageURL", "IsTripOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, "https://prd-wret.s3.us-west-2.amazonaws.com/assets/palladium/production/s3fs-public/styles/full_width/public/thumbnails/image/a39.jpg", "https://live.staticflickr.com/4224/34706522321_18d3d6b5db_b.jpg", true, "Backpack a far distance in a day and a half, but jump in multiple hot springs along the way!", "Joshua Tree Hot Springs Hopping", 35.95m, "One night adventure backpacking hot spring to hot spring" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 5,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "ImageURL", "IsTripOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 3, "https://beaches.lacounty.gov/wp-content/uploads/2016/10/Dockweiler_1.jpg", "https://www.visitmarinadelrey.com/wp-content/gallery/dockweiler-beach/dockweiler-entrance-sign.jpg", false, "Chill out Satuday by cooking kabobs or surfing Dockweiler State Beach's beautiful blue waves", "Dockweiler Surfing", 15.95m, "BBQ on the beach with medium waves" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 6,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "ImageURL", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, "https://lh3.googleusercontent.com/proxy/dGKYwoJzBhUjDK65mFz8PwqvgMXz8K58CeC0jsEfpN8K8uxh1Y9mKfvcluIlk4awoNWfSDr-1nYRDVigVgC8cSZIuvxA9T-_yYXTH2PfgTvAxDVLgJAvu1q2zZRsq9R4lo6VDA0Hgu8", "https://www.nps.gov/chis/planyourvisit/images/960-IMG_5362.jpg?maxwidth=650&autorotate=false", "Don't want to get too dirty on the weekends? Backpack out to a rented shelter for some more casual camping.", "Channel Islands Backpack Glamping", 40.95m, "Backpack one night on the main island to a rented structure" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 7,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "ImageURL", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 1, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/19/a4/e4/8b/lodgepole-campground.jpg?w=900&h=-1&s=1", "https://cdn.pixabay.com/photo/2010/12/17/00/26/morro-rock-3687_960_720.jpg", "Long day hikes with evening board games will be your 3 day holiday weekend at this giant forest!", "Sequoia National Park Camping", 55.95m, "2 day camping at Lodgepole Campground" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 4,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "ImageURL", "IsTripOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 1, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/19/a4/e4/8b/lodgepole-campground.jpg?w=900&h=-1&s=1", "https://cdn.pixabay.com/photo/2010/12/17/00/26/morro-rock-3687_960_720.jpg", false, "Long day hikes with evening board games will be your 3 day holiday weekend at this giant forest!", "Sequoia National Park Camping", 55.95m, "2 day camping at Lodgepole Campground" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 5,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "ImageURL", "IsTripOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, "https://prd-wret.s3.us-west-2.amazonaws.com/assets/palladium/production/s3fs-public/styles/full_width/public/thumbnails/image/a39.jpg", "https://live.staticflickr.com/4224/34706522321_18d3d6b5db_b.jpg", true, "Backpack a far distance in a day and a half, but jump in multiple hot springs along the way!", "Joshua Tree Hot Springs Hopping", 35.95m, "One night adventure backpacking hot spring to hot spring" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 6,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "ImageURL", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 3, "https://beaches.lacounty.gov/wp-content/uploads/2016/10/Dockweiler_1.jpg", "https://www.visitmarinadelrey.com/wp-content/gallery/dockweiler-beach/dockweiler-entrance-sign.jpg", "Chill out Satuday by cooking kabobs or surfing Dockweiler State Beach's beautiful blue waves", "Dockweiler Surfing", 15.95m, "BBQ on the beach with medium waves" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 7,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "ImageURL", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, "https://lh3.googleusercontent.com/proxy/dGKYwoJzBhUjDK65mFz8PwqvgMXz8K58CeC0jsEfpN8K8uxh1Y9mKfvcluIlk4awoNWfSDr-1nYRDVigVgC8cSZIuvxA9T-_yYXTH2PfgTvAxDVLgJAvu1q2zZRsq9R4lo6VDA0Hgu8", "https://www.nps.gov/chis/planyourvisit/images/960-IMG_5362.jpg?maxwidth=650&autorotate=false", "Don't want to get too dirty on the weekends? Backpack out to a rented shelter for some more casual camping.", "Channel Islands Backpack Glamping", 40.95m, "Backpack one night on the main island to a rented structure" });
        }
    }
}

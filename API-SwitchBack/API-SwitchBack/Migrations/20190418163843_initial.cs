using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_SwitchBack.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trail",
                columns: table => new
                {
                    TrailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApiID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    Difficulty = table.Column<string>(nullable: true),
                    Stars = table.Column<double>(nullable: false),
                    StarVotes = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    ImgSqSmall = table.Column<string>(nullable: true),
                    ImgSmall = table.Column<string>(nullable: true),
                    ImgSmallMed = table.Column<string>(nullable: true),
                    ImgMedium = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Ascent = table.Column<int>(nullable: false),
                    Descent = table.Column<int>(nullable: false),
                    High = table.Column<int>(nullable: false),
                    Low = table.Column<int>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    ConditionStatus = table.Column<string>(nullable: true),
                    ConditionDetails = table.Column<string>(nullable: true),
                    ConditionDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trail", x => x.TrailID);
                });

            migrationBuilder.CreateTable(
                name: "UserRatings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TrailInfoID = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    TrailID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRatings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserRatings_Trail_TrailID",
                        column: x => x.TrailID,
                        principalTable: "Trail",
                        principalColumn: "TrailID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Trail",
                columns: new[] { "TrailID", "ApiID", "Ascent", "ConditionDate", "ConditionDetails", "ConditionStatus", "Descent", "Difficulty", "High", "ImgMedium", "ImgSmall", "ImgSmallMed", "ImgSqSmall", "Latitude", "Length", "Location", "Longitude", "Low", "Name", "StarVotes", "Stars", "Summary", "Type", "Url" },
                values: new object[] { 1, 7005406, 1619, "2019-03-28 11:05:03", "Dry", "All Clear", -1618, "blue", 1807, "https://cdn-files.apstatic.com/hike/7004771_medium_1554310760.jpg", "https://cdn-files.apstatic.com/hike/7004771_small_1554310760.jpg", "https://cdn-files.apstatic.com/hike/7004771_smallMed_1554310760.jpg", "https://cdn-files.apstatic.com/hike/7004771_sqsmall_1554310760.jpg", 47.499899999999997, 3.8999999999999999, "Issaquah, Washington", -122.0211, 188, "Poo Poo Point via Chirico Trail", 50, 4.2999999999999998, "A great place for a picnic and watching paragliders!", "Featured Hike", "https://www.hikingproject.com/trail/7005406/poo-poo-point-via-chirico-trail" });

            migrationBuilder.InsertData(
                table: "Trail",
                columns: new[] { "TrailID", "ApiID", "Ascent", "ConditionDate", "ConditionDetails", "ConditionStatus", "Descent", "Difficulty", "High", "ImgMedium", "ImgSmall", "ImgSmallMed", "ImgSqSmall", "Latitude", "Length", "Location", "Longitude", "Low", "Name", "StarVotes", "Stars", "Summary", "Type", "Url" },
                values: new object[] { 2, 7027304, 690, "2019-04-02 00:00:00", "Mostly Dry: Snow free", "All Clear", -676, "greenBlue", 1278, "https://cdn-files.apstatic.com/hike/7031970_medium_1554932139.jpg", "https://cdn-files.apstatic.com/hike/7031970_small_1554932139.jpg", "https://cdn-files.apstatic.com/hike/7031970_smallMed_1554932139.jpg", "https://cdn-files.apstatic.com/hike/7031970_sqsmall_1554932139.jpg", 47.534599999999998, 5.0999999999999996, "Newcastle, Washington", -122.12860000000001, 676, "Cougar Mountain Red Town Loop", 24, 4.4000000000000004, "This well-maintained rolling loop is a treat just minutes from Seattle.", "Featured Hike", "https://www.hikingproject.com/trail/7027304/cougar-mountain-red-town-loop" });

            migrationBuilder.CreateIndex(
                name: "IX_UserRatings_TrailID",
                table: "UserRatings",
                column: "TrailID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRatings");

            migrationBuilder.DropTable(
                name: "Trail");
        }
    }
}

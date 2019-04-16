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
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    summary = table.Column<string>(nullable: true),
                    difficulty = table.Column<string>(nullable: true),
                    stars = table.Column<float>(nullable: false),
                    starVotes = table.Column<int>(nullable: false),
                    location = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true),
                    imgSqSmall = table.Column<string>(nullable: true),
                    imgSmall = table.Column<string>(nullable: true),
                    imgSmallMed = table.Column<string>(nullable: true),
                    imgMedium = table.Column<string>(nullable: true),
                    length = table.Column<float>(nullable: false),
                    ascent = table.Column<int>(nullable: false),
                    descent = table.Column<int>(nullable: false),
                    high = table.Column<int>(nullable: false),
                    low = table.Column<int>(nullable: false),
                    longitude = table.Column<float>(nullable: false),
                    latitude = table.Column<float>(nullable: false),
                    conditionStatus = table.Column<string>(nullable: true),
                    conditionDetails = table.Column<string>(nullable: true),
                    conditionDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trail", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserRatings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TrailInfoID = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Trailid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRatings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserRatings_Trail_Trailid",
                        column: x => x.Trailid,
                        principalTable: "Trail",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRatings_Trailid",
                table: "UserRatings",
                column: "Trailid");
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

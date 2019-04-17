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
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    Difficulty = table.Column<string>(nullable: true),
                    Stars = table.Column<float>(nullable: false),
                    StarVotes = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    ImgSqSmall = table.Column<string>(nullable: true),
                    ImgSmall = table.Column<string>(nullable: true),
                    ImgSmallMed = table.Column<string>(nullable: true),
                    ImgMedium = table.Column<string>(nullable: true),
                    Length = table.Column<float>(nullable: false),
                    Ascent = table.Column<int>(nullable: false),
                    Descent = table.Column<int>(nullable: false),
                    High = table.Column<int>(nullable: false),
                    Low = table.Column<int>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    ConditionStatus = table.Column<string>(nullable: true),
                    ConditionDetails = table.Column<string>(nullable: true),
                    ConditionDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trail", x => x.ID);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

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

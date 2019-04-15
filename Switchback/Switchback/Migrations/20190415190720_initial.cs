using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Switchback.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DefaultReturns",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultReturns", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserRating",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TrailInfoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRating", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "DefaultReturns",
                columns: new[] { "ID", "Message" },
                values: new object[] { 1, "Hello world" });

            migrationBuilder.InsertData(
                table: "DefaultReturns",
                columns: new[] { "ID", "Message" },
                values: new object[] { 2, "Hello Website" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefaultReturns");

            migrationBuilder.DropTable(
                name: "UserRating");
        }
    }
}

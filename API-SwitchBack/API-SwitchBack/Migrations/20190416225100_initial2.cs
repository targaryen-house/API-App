using Microsoft.EntityFrameworkCore.Migrations;

namespace API_SwitchBack.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRatings_Trail_Trailid",
                table: "UserRatings");

            migrationBuilder.RenameColumn(
                name: "Trailid",
                table: "UserRatings",
                newName: "TrailID");

            migrationBuilder.RenameIndex(
                name: "IX_UserRatings_Trailid",
                table: "UserRatings",
                newName: "IX_UserRatings_TrailID");

            migrationBuilder.RenameColumn(
                name: "url",
                table: "Trail",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Trail",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "summary",
                table: "Trail",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "stars",
                table: "Trail",
                newName: "Stars");

            migrationBuilder.RenameColumn(
                name: "starVotes",
                table: "Trail",
                newName: "StarVotes");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Trail",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "low",
                table: "Trail",
                newName: "Low");

            migrationBuilder.RenameColumn(
                name: "longitude",
                table: "Trail",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "location",
                table: "Trail",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "length",
                table: "Trail",
                newName: "Length");

            migrationBuilder.RenameColumn(
                name: "latitude",
                table: "Trail",
                newName: "Latitude");

            migrationBuilder.RenameColumn(
                name: "imgSqSmall",
                table: "Trail",
                newName: "ImgSqSmall");

            migrationBuilder.RenameColumn(
                name: "imgSmallMed",
                table: "Trail",
                newName: "ImgSmallMed");

            migrationBuilder.RenameColumn(
                name: "imgSmall",
                table: "Trail",
                newName: "ImgSmall");

            migrationBuilder.RenameColumn(
                name: "imgMedium",
                table: "Trail",
                newName: "ImgMedium");

            migrationBuilder.RenameColumn(
                name: "high",
                table: "Trail",
                newName: "High");

            migrationBuilder.RenameColumn(
                name: "difficulty",
                table: "Trail",
                newName: "Difficulty");

            migrationBuilder.RenameColumn(
                name: "descent",
                table: "Trail",
                newName: "Descent");

            migrationBuilder.RenameColumn(
                name: "conditionStatus",
                table: "Trail",
                newName: "ConditionStatus");

            migrationBuilder.RenameColumn(
                name: "conditionDetails",
                table: "Trail",
                newName: "ConditionDetails");

            migrationBuilder.RenameColumn(
                name: "conditionDate",
                table: "Trail",
                newName: "ConditionDate");

            migrationBuilder.RenameColumn(
                name: "ascent",
                table: "Trail",
                newName: "Ascent");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Trail",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatings_Trail_TrailID",
                table: "UserRatings",
                column: "TrailID",
                principalTable: "Trail",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRatings_Trail_TrailID",
                table: "UserRatings");

            migrationBuilder.RenameColumn(
                name: "TrailID",
                table: "UserRatings",
                newName: "Trailid");

            migrationBuilder.RenameIndex(
                name: "IX_UserRatings_TrailID",
                table: "UserRatings",
                newName: "IX_UserRatings_Trailid");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Trail",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Trail",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Trail",
                newName: "summary");

            migrationBuilder.RenameColumn(
                name: "Stars",
                table: "Trail",
                newName: "stars");

            migrationBuilder.RenameColumn(
                name: "StarVotes",
                table: "Trail",
                newName: "starVotes");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Trail",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Low",
                table: "Trail",
                newName: "low");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Trail",
                newName: "longitude");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Trail",
                newName: "location");

            migrationBuilder.RenameColumn(
                name: "Length",
                table: "Trail",
                newName: "length");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Trail",
                newName: "latitude");

            migrationBuilder.RenameColumn(
                name: "ImgSqSmall",
                table: "Trail",
                newName: "imgSqSmall");

            migrationBuilder.RenameColumn(
                name: "ImgSmallMed",
                table: "Trail",
                newName: "imgSmallMed");

            migrationBuilder.RenameColumn(
                name: "ImgSmall",
                table: "Trail",
                newName: "imgSmall");

            migrationBuilder.RenameColumn(
                name: "ImgMedium",
                table: "Trail",
                newName: "imgMedium");

            migrationBuilder.RenameColumn(
                name: "High",
                table: "Trail",
                newName: "high");

            migrationBuilder.RenameColumn(
                name: "Difficulty",
                table: "Trail",
                newName: "difficulty");

            migrationBuilder.RenameColumn(
                name: "Descent",
                table: "Trail",
                newName: "descent");

            migrationBuilder.RenameColumn(
                name: "ConditionStatus",
                table: "Trail",
                newName: "conditionStatus");

            migrationBuilder.RenameColumn(
                name: "ConditionDetails",
                table: "Trail",
                newName: "conditionDetails");

            migrationBuilder.RenameColumn(
                name: "ConditionDate",
                table: "Trail",
                newName: "conditionDate");

            migrationBuilder.RenameColumn(
                name: "Ascent",
                table: "Trail",
                newName: "ascent");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Trail",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatings_Trail_Trailid",
                table: "UserRatings",
                column: "Trailid",
                principalTable: "Trail",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

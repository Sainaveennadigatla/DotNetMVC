using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityApplication.Data.Migrations
{
    public partial class AddedCreatorAndStatusToInvice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatorId",
                table: "invoice",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "invoice",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "invoice");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "invoice");
        }
    }
}

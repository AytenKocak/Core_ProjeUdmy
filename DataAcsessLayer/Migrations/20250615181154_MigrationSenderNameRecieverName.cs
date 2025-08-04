using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcsessLayer.Migrations
{
    public partial class MigrationSenderNameRecieverName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecevierName",
                table: "WriterMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderName",
                table: "WriterMessages",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecevierName",
                table: "WriterMessages");

            migrationBuilder.DropColumn(
                name: "SenderName",
                table: "WriterMessages");
        }
    }
}

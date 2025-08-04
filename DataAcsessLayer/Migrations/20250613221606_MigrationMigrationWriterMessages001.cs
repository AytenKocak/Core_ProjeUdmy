using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcsessLayer.Migrations
{
    public partial class MigrationMigrationWriterMessages001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageContent",
                table: "WriterMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageContent",
                table: "WriterMessages");
        }
    }
}

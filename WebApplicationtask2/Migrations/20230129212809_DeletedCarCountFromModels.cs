using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationtask2.Migrations
{
    public partial class DeletedCarCountFromModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarCount",
                table: "Models");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarCount",
                table: "Models",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

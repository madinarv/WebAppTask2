using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationtask2.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Markas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Markas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

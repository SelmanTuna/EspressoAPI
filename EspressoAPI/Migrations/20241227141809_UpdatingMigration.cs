using Microsoft.EntityFrameworkCore.Migrations;

namespace EspressoAPI.Migrations
{
    public partial class UpdatingMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "SubMenu",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Image",
                table: "SubMenu",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

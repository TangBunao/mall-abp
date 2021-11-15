using Microsoft.EntityFrameworkCore.Migrations;

namespace TangBunao.Mall.Migrations
{
    public partial class AddIsDeletedtoProductCategoryentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PmsProductCategory",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PmsProductCategory");
        }
    }
}

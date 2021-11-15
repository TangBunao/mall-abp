using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TangBunao.Mall.Migrations
{
    public partial class AddDeletedByIdDeletionTimetoProductCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DeletedById",
                table: "PmsProductCategory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "PmsProductCategory",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "PmsProductCategory");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "PmsProductCategory");
        }
    }
}

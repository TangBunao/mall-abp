using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TangBunao.Mall.Migrations
{
    public partial class AddBrandEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PmsBrand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    FirstLetter = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Sort = table.Column<int>(type: "int", nullable: false),
                    FactoryStatus = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    ShowStatus = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    ProductCount = table.Column<int>(type: "int", nullable: false),
                    ProductCommentCount = table.Column<int>(type: "int", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BigPic = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BrandStory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PmsBrand", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PmsBrand");
        }
    }
}

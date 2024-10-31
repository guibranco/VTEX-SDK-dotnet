using Microsoft.EntityFrameworkCore.Migrations;

namespace Migrations
{
    public partial class AddBrandSubcollectionRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrandSubcollection",
                columns: table => new
                {
                    BrandId = table.Column<int>(nullable: false),
                    SubcollectionId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandSubcollection", x => new { x.BrandId, x.SubcollectionId });
                    table.ForeignKey(
                        name: "FK_BrandSubcollection_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrandSubcollection_Subcollections_SubcollectionId",
                        column: x => x.SubcollectionId,
                        principalTable: "Subcollections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "BrandSubcollection");
        }
    }
}

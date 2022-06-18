using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class blog_and_subscategory_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubsCategorySubCategory",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SubsCategories",
                columns: table => new
                {
                    SubCategory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubsCategories", x => x.SubCategory);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_SubsCategorySubCategory",
                table: "Blogs",
                column: "SubsCategorySubCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_SubsCategories_SubsCategorySubCategory",
                table: "Blogs",
                column: "SubsCategorySubCategory",
                principalTable: "SubsCategories",
                principalColumn: "SubCategory",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_SubsCategories_SubsCategorySubCategory",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "SubsCategories");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_SubsCategorySubCategory",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "SubsCategorySubCategory",
                table: "Blogs");
        }
    }
}

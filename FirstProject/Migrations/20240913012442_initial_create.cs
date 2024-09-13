using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FirstProject.Migrations
{
    /// <inheritdoc />
    public partial class initial_create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A collection of written or printed works", "Books" },
                    { 2, "Books for writing notes", "NoteBooks" },
                    { 3, "Writing instruments made of graphite", "Pencils" },
                    { 4, "Various coloring materials", "Colors" },
                    { 5, "Various coloring materials", "Colors" },
                    { 6, "Various coloring materials", "Colors" },
                    { 7, "Various coloring materials", "Colors" },
                    { 8, "Various coloring materials", "Colors" },
                    { 9, "Various coloring materials", "Colors" },
                    { 10, "Various coloring materials", "Colors" },
                    { 11, "Various coloring materials", "Colors" },
                    { 12, "Various coloring materials", "Colors" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImagePath", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, 1, "qq", "books1.jpg", 1, 1, "Books" },
                    { 2, 2, "rr", "books2.jpg", 2, 1, "Books" },
                    { 3, 3, "rr", "story.jpg", 3, 1, "Story" },
                    { 4, 4, "rr", "paper1.jpg", 4, 1, "Paper" },
                    { 5, 5, "rr", "pince.jpg", 5, 2, "Pince" },
                    { 6, 6, "rr", "paper2.jpg", 6, 2, "Paper" },
                    { 7, 7, "rr", "color.jpg", 7, 2, "Color" },
                    { 8, 8, "rr", "books3.jpg", 8, 2, "Books" },
                    { 9, 9, "rr", "paper3.jpg", 9, 2, "Paper" },
                    { 10, 10, "rr", "highl.jpg", 10, 3, "Highl" },
                    { 11, 11, "rr", "note.jpg", 11, 3, "Note" },
                    { 12, 12, "rr", "paper4.jpg", 12, 3, "Paper" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

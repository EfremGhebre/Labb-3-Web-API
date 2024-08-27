using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Labb_3_Web_API.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonInterests",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    InterestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonInterests", x => new { x.PersonId, x.InterestId });
                    table.ForeignKey(
                        name: "FK_PersonInterests_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonInterests_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterestId = table.Column<int>(type: "int", nullable: false),
                    PersonInterestInterestId = table.Column<int>(type: "int", nullable: true),
                    PersonInterestPersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Links_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Links_PersonInterests_PersonInterestPersonId_PersonInterestInterestId",
                        columns: x => new { x.PersonInterestPersonId, x.PersonInterestInterestId },
                        principalTable: "PersonInterests",
                        principalColumns: new[] { "PersonId", "InterestId" });
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Capturing moments through the lens of a camera.", "Photography" },
                    { 2, "Exploring culinary techniques and creating delicious dishes.", "Cooking" },
                    { 3, "Cultivating plants, flowers, and vegetables in a garden.", "Gardening" },
                    { 4, "Exploring nature trails and enjoying outdoor adventures.", "Hiking" },
                    { 5, "Expressing creativity through painting on various canvases.", "Painting" },
                    { 6, "Exploring new countries, cultures, and experiences.", "Traveling" },
                    { 7, "Riding bicycles for fitness, fun, or transportation.", "Cycling" },
                    { 8, "Enjoying and creating music across different genres.", "Music" },
                    { 9, "Diving into books and exploring different worlds through literature.", "Reading" },
                    { 10, "Practicing yoga to enhance physical and mental well-being.", "Yoga" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "John Doe", "123-456-7890" },
                    { 2, "Jane Smith", "987-654-3210" },
                    { 3, "Michael Johnson", "555-234-5678" },
                    { 4, "Emily Davis", "555-345-6789" },
                    { 5, "David Wilson", "555-456-7890" },
                    { 6, "Sophia Brown", "555-567-8901" },
                    { 7, "James Taylor", "555-678-9012" },
                    { 8, "Isabella Moore", "555-789-0123" },
                    { 9, "William White", "555-890-1234" },
                    { 10, "Olivia Harris", "555-901-2345" },
                    { 11, "Benjamin Clark", "555-012-3456" },
                    { 12, "Ava Lewis", "555-123-4567" },
                    { 13, "Lucas Walker", "555-234-5678" },
                    { 14, "Mia Hall", "555-345-6789" },
                    { 15, "Alexander Young", "555-456-7890" }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "InterestId", "PersonInterestInterestId", "PersonInterestPersonId", "Url" },
                values: new object[,]
                {
                    { 1, 1, null, null, "https://www.digitalphotomentor.com" },
                    { 2, 2, null, null, "https://www.seriouseats.com" },
                    { 3, 3, null, null, "https://www.gardeners.com" },
                    { 4, 4, null, null, "https://www.alltrails.com" },
                    { 5, 5, null, null, "https://www.artistsnetwork.com" },
                    { 6, 6, null, null, "https://www.lonelyplanet.com" },
                    { 7, 7, null, null, "https://www.bicycling.com" },
                    { 8, 8, null, null, "https://www.rollingstone.com/music" },
                    { 9, 9, null, null, "https://www.goodreads.com" },
                    { 10, 10, null, null, "https://www.yogajournal.com" }
                });

            migrationBuilder.InsertData(
                table: "PersonInterests",
                columns: new[] { "InterestId", "PersonId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 2, 2 },
                    { 4, 2 },
                    { 1, 3 },
                    { 5, 3 },
                    { 6, 3 },
                    { 3, 4 },
                    { 7, 4 },
                    { 4, 5 },
                    { 8, 5 },
                    { 9, 6 },
                    { 5, 7 },
                    { 10, 7 },
                    { 6, 8 },
                    { 7, 8 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 9 },
                    { 1, 10 },
                    { 2, 11 },
                    { 4, 11 },
                    { 3, 12 },
                    { 5, 12 },
                    { 6, 13 },
                    { 7, 14 },
                    { 8, 14 },
                    { 1, 15 },
                    { 9, 15 },
                    { 10, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Links_InterestId",
                table: "Links",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PersonInterestPersonId_PersonInterestInterestId",
                table: "Links",
                columns: new[] { "PersonInterestPersonId", "PersonInterestInterestId" });

            migrationBuilder.CreateIndex(
                name: "IX_PersonInterests_InterestId",
                table: "PersonInterests",
                column: "InterestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "PersonInterests");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}

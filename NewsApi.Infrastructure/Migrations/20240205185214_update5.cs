using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NewsApi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CountOfVisits = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_News_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserIp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRegion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statistics_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Age", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, 23, "Stas", "Smoliar" },
                    { 2, 12, "Denys", "Vakulin" },
                    { 3, 42, "Sergii", "Brown" },
                    { 4, 22, "Andrii", "Bower" },
                    { 5, 32, "Ktay", "Tyson" },
                    { 6, 54, "Ali", "Muhamed" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Category about sport", "Sport" },
                    { 2, "Category about science", "Science" },
                    { 3, "Category about medicine", "Medicine" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Admin Role", "Admin" },
                    { 2, "Redactor Role", "Redactor" },
                    { 3, "Writer Role", "Writer" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Age", "Email", "Name", "Phone", "RoleId", "Surname" },
                values: new object[,]
                {
                    { 1, 19, "richardpatti11@gmail.com", "Richard", "+380971373212", 2, "Pati" },
                    { 2, 32, "thombook33@gmail.com", "Thom", "+380667776655", 3, "Booking" },
                    { 3, 22, "eldarnig00@gmail.com", "Eldar", "+380112223344", 1, "Nig" },
                    { 4, 46, "griff_simpson@gmail.com", "Griffin", "+380112223344", 1, "Simpson" },
                    { 5, 25, "marchsimp@gmail.com", "March", "+380112223344", 1, "Simpsons" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CountOfVisits", "Description", "Text", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, 0, "Our insiders makes the moves they think NBA GMs should be making ahead of Feb. 8, including a big deal to shake up the Lakers.", "The 2024 NBA trade deadline is fast approaching, and while some teams have already been active, there are still plenty of others who need to make moves.\r\n\r\nWith that in mind, we asked our", "Six big NBA trades we want to see before the deadline" },
                    { 2, 2, 1, 0, "The Lions surrendered a 17-point second-half lead, while the vaunted Ravens scored just 10 points. Here's how the 49ers and Chiefs won.", "Chiefs-Ravens was a slow burn, as Kansas City got out to an early lead and held onto it throughout. Baltimore got closer and closer to competing as the game went along, but mistakes at ", "Barnwell: The truth behind Detroit's disastrous second half and Baltimore's botched Super Bowl chance" },
                    { 3, 3, 2, 0, "Alzheimer’s isn’t contagious. But contaminated growth hormone injections caused early-onset Alzheimer’s in some recipients, a new study suggests.", "Under extremely rare circumstances, it appears that Alzheimer’s disease can be transmitted between people. Five people who received ", "Under very rare conditions, Alzheimer’s disease may be transmitted" },
                    { 4, 4, 2, 0, "New climate data for ancient Italy point to temperature and rainfall influences on past infectious disease outbreaks.", "For those who enjoy pondering the Roman Empire’s rise and fall — you know who you are — consider the close link between ancient climate change and infectious disease outbreaks. ", "Cold, dry snaps accompanied three plagues that struck the Roman Empire" },
                    { 5, 5, 3, 0, "A lack of funding, mentorship, and compensation for clinician-researchers could threaten America's standing as the world leader in biomedicine.", "Recent reporting has shown that the number of physician-scientists — doctors who both practice medicine and perform scientific research — in the United States is dropping rapidly. That's a problem, because physician-scientists are uniquely equipped to make scientific", "The Emerging Physician-Scientist Crisis in America" },
                    { 6, 6, 3, 0, "There is some evidence — both scientific and anecdotal — that some diets may help with the management of long COVID symptoms. Which...", "For many people, particularly following vaccination, infection with SARS-CoV-2, the virus that causes COVID-19, resolves within a few days. ", "Could some diets help manage long COVID?" }
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "NewsId", "UserIp", "UserRegion", "UserSource" },
                values: new object[,]
                {
                    { 1, 1, "143.234.523.1", "Ukraine", "Mozilla" },
                    { 2, 2, "883.674.263.2", "US", "Google" },
                    { 3, 2, "773.234.573.3", "Canada", "Explorer" },
                    { 4, 4, "123.664.563.4", "UK", "Explorer" },
                    { 5, 4, "743.234.503.5", "France", "Mozilla" },
                    { 6, 1, "843.774.563.6", "Spain", "Google" },
                    { 7, 3, "213.244.713.7", "France", "Explorer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorId",
                table: "News",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoryId",
                table: "News",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_NewsId",
                table: "Statistics",
                column: "NewsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

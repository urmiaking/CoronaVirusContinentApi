using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaVirusContinentApi.Migrations
{
    public partial class InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Continent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continent", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Continent",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "آسیا" },
                    { 2, "آمریکا" },
                    { 3, "آفریقا" },
                    { 4, "استرالیا" },
                    { 5, "اروپا" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Continent");
        }
    }
}

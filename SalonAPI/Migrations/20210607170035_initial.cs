using Microsoft.EntityFrameworkCore.Migrations;

namespace SalonAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kolor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rocznik = table.Column<int>(type: "int", nullable: false),
                    przebieg = table.Column<int>(type: "int", nullable: false),
                    moc = table.Column<int>(type: "int", nullable: false),
                    drzwi = table.Column<int>(type: "int", nullable: false),
                    cena = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}

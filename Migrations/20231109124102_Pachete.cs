using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicatieProiect.Migrations
{
    public partial class Pachete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pachet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eveniment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Restaurant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Informatii = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Promotii = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pachet", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacitate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locatie = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pachet");

            migrationBuilder.DropTable(
                name: "Restaurant");
        }
    }
}

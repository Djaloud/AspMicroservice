using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroserviceEtudiant.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "etudiants",
                columns: table => new
                {
                    id_etudiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etudiants", x => x.id_etudiant);
                });

            migrationBuilder.InsertData(
                table: "etudiants",
                columns: new[] { "id_etudiant", "Nom", "Prenom", "cne" },
                values: new object[] { 1, "Djaloud", "Louariga", "CNE01" });

            migrationBuilder.InsertData(
                table: "etudiants",
                columns: new[] { "id_etudiant", "Nom", "Prenom", "cne" },
                values: new object[] { 2, "Nokri", "MIRI", "CNE02" });

            migrationBuilder.InsertData(
                table: "etudiants",
                columns: new[] { "id_etudiant", "Nom", "Prenom", "cne" },
                values: new object[] { 3, "Yassine", "Hafid", "CNE03" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "etudiants");
        }
    }
}

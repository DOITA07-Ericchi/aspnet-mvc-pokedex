using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokédex.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<int>(type: "integer", nullable: false),
                    Nome = table.Column<string>(type: "varchar(10)", nullable: false),
                    Descrizione = table.Column<string>(type: "text", nullable: false),
                    Tipo1 = table.Column<byte>(type: "tinyint", nullable: false),
                    Tipo2 = table.Column<byte>(type: "tinyint", nullable: false),
                    Immagine = table.Column<string>(type: "varchar(100)", nullable: false),
                    Stato = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}

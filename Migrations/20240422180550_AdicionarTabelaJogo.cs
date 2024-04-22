using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JogoBicho.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTabelaJogo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeAnimal = table.Column<string>(type: "TEXT", nullable: false),
                    ID_Result = table.Column<int>(type: "INTEGER", nullable: false),
                    Premio = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogo", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogo");
        }
    }
}

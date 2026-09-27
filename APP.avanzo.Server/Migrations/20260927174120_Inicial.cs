using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace APP_avanzo.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    Promedio_Inall_Mate = table.Column<float>(type: "real", nullable: false),
                    Promedio_Avanzo_Mate = table.Column<float>(type: "real", nullable: false),
                    Promedio_final_Mate = table.Column<float>(type: "real", nullable: false),
                    Promedio_Inall_Ciencias = table.Column<float>(type: "real", nullable: false),
                    Promedio_Avanzo_Ciencias = table.Column<float>(type: "real", nullable: false),
                    Promedio_final_Ciencias = table.Column<float>(type: "real", nullable: false),
                    Promedio_Inall_Sociales = table.Column<float>(type: "real", nullable: false),
                    Promedio_Avanzo_Sociales = table.Column<float>(type: "real", nullable: false),
                    Promedio_final_Sociales = table.Column<float>(type: "real", nullable: false),
                    Promedio_Inall_Lenguaje = table.Column<float>(type: "real", nullable: false),
                    Promedio_Avanzo_Lenguaje = table.Column<float>(type: "real", nullable: false),
                    Promedio_final_Lenguaje = table.Column<float>(type: "real", nullable: false),
                    Promedio_Final = table.Column<float>(type: "real", nullable: false),
                    Estado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calculos");
        }
    }
}

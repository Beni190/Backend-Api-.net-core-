using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamenRest.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "codigos_postales",
                columns: table => new
                {
                    id_postal = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo_postal = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    asentamiento_postal = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    tipo_asentamiento_postal = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    municipio_postal = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    estado_postal = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    ciudad_postal = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    zona_postal = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__codigos___E7D259D44C0321F9", x => x.id_postal);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id_user = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_user = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    email_user = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    pass_user = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    facha_sistema_user = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Privilegio_user = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    nombre_completo_user = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id_user);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "codigos_postales");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

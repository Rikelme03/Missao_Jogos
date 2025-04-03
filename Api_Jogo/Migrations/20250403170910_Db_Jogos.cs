using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_Jogo.Migrations
{
    /// <inheritdoc />
    public partial class Db_Jogos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogos",
                columns: table => new
                {
                    JogosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeJogo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Plataforma = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogos", x => x.JogosId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeUsuario = table.Column<string>(type: "varchar(50)", nullable: false),
                    NickName = table.Column<string>(type: "varchar(80)", nullable: false),
                    JogosId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Jogos_JogosId",
                        column: x => x.JogosId,
                        principalTable: "Jogos",
                        principalColumn: "JogosId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_NomeJogo",
                table: "Jogos",
                column: "NomeJogo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_JogosId",
                table: "Usuarios",
                column: "JogosId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_NomeUsuario",
                table: "Usuarios",
                column: "NomeUsuario",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Jogos");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class _100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "adm");

            migrationBuilder.CreateTable(
                name: "Alerta",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "varchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(max)", nullable: true),
                    DataInicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ordem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alerta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Andar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "varchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ordem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Andar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "varchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ordem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Configuracao",
                schema: "adm",
                columns: table => new
                {
                    Parametro = table.Column<string>(type: "varchar(450)", nullable: false),
                    Valor = table.Column<string>(type: "varchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuracao", x => x.Parametro);
                });

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "varchar(max)", nullable: true),
                    Email = table.Column<string>(type: "varchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ordem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(max)", nullable: false),
                    Valor = table.Column<string>(type: "varchar(max)", nullable: false),
                    Erro = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sistema",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "varchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(max)", nullable: true),
                    TagIcon = table.Column<string>(type: "varchar(max)", nullable: true),
                    Url = table.Column<string>(type: "varchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ordem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sistema", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(max)", nullable: false),
                    Tentativas = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ordem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Secao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "varchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(max)", nullable: true),
                    IdAndar = table.Column<int>(type: "int", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ordem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Secao_Andar_IdAndar",
                        column: x => x.IdAndar,
                        principalTable: "Andar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Colaborador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCargo = table.Column<int>(type: "int", nullable: true),
                    IdSecao = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "varchar(max)", nullable: false),
                    UrlImagem = table.Column<string>(type: "varchar(max)", nullable: true),
                    Email = table.Column<string>(type: "varchar(max)", nullable: true),
                    Ramal = table.Column<string>(type: "varchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ordem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaborador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colaborador_Cargo_IdCargo",
                        column: x => x.IdCargo,
                        principalTable: "Cargo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Colaborador_Secao_IdSecao",
                        column: x => x.IdSecao,
                        principalTable: "Secao",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_IdCargo",
                table: "Colaborador",
                column: "IdCargo");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_IdSecao",
                table: "Colaborador",
                column: "IdSecao");

            migrationBuilder.CreateIndex(
                name: "IX_Secao_IdAndar",
                table: "Secao",
                column: "IdAndar");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alerta",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Colaborador");

            migrationBuilder.DropTable(
                name: "Configuracao",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "Log",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Sistema");

            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Secao");

            migrationBuilder.DropTable(
                name: "Andar");
        }
    }
}

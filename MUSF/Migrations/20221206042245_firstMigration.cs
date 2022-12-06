using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musf.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcompanharMissoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acoes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Missionario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Local = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegiaoBrasil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RegiaoPais = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcompanharMissoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Misao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Objetivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Envolvidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Etapas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExcluidoEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExcluidoPor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Misao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Missionario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Igreja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExcluidoEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExcluidoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NecessidadeMissoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Necessidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sugestao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NecessidadeMissoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExcluidoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExcluidoEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExcluidoEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExcluidoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransacaoUsuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoTransacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeTransacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataTransacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransacaoUsuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MissaoMissionario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MissaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MissionarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExcluidoEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExcluidoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissaoMissionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MissaoMissionario_Misao_MissaoId",
                        column: x => x.MissaoId,
                        principalTable: "Misao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MissaoMissionario_Missionario_MissionarioId",
                        column: x => x.MissionarioId,
                        principalTable: "Missionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExcluidoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExcluidoEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PerfilId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MissaoUsuario",
                columns: table => new
                {
                    MissaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoluntariosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissaoUsuario", x => new { x.MissaoId, x.VoluntariosId });
                    table.ForeignKey(
                        name: "FK_MissaoUsuario_Misao_MissaoId",
                        column: x => x.MissaoId,
                        principalTable: "Misao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MissaoUsuario_Usuario_VoluntariosId",
                        column: x => x.VoluntariosId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MissaoMissionario_MissaoId",
                table: "MissaoMissionario",
                column: "MissaoId");

            migrationBuilder.CreateIndex(
                name: "IX_MissaoMissionario_MissionarioId",
                table: "MissaoMissionario",
                column: "MissionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_MissaoUsuario_VoluntariosId",
                table: "MissaoUsuario",
                column: "VoluntariosId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PerfilId",
                table: "Usuario",
                column: "PerfilId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcompanharMissoes");

            migrationBuilder.DropTable(
                name: "MissaoMissionario");

            migrationBuilder.DropTable(
                name: "MissaoUsuario");

            migrationBuilder.DropTable(
                name: "NecessidadeMissoes");

            migrationBuilder.DropTable(
                name: "Transacao");

            migrationBuilder.DropTable(
                name: "TransacaoUsuario");

            migrationBuilder.DropTable(
                name: "Missionario");

            migrationBuilder.DropTable(
                name: "Misao");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Perfil");
        }
    }
}

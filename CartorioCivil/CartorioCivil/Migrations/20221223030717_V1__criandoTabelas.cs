using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CartorioCivil.Migrations
{
    /// <inheritdoc />
    public partial class V1criandoTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Casamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataCasamento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nascimentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dataRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    nomeRegistrado = table.Column<string>(type: "text", nullable: false),
                    nomePai = table.Column<string>(type: "text", nullable: false),
                    nascimentoPai = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    nomeMae = table.Column<string>(type: "text", nullable: false),
                    nascimentoMae = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    cpfPai = table.Column<string>(type: "text", nullable: false),
                    cpfMae = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nascimentos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Obitos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataObito = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NomeFalecido = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NomePai = table.Column<string>(type: "text", nullable: false),
                    NomeMae = table.Column<string>(type: "text", nullable: false),
                    DataNascimentoPai = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataNascimentoMae = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obitos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conjuges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Cpf = table.Column<string>(type: "text", nullable: false),
                    NomePai = table.Column<string>(type: "text", nullable: false),
                    NomeMae = table.Column<string>(type: "text", nullable: false),
                    DataNascimentoPai = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataNascimentoMae = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CpfPai = table.Column<string>(type: "text", nullable: false),
                    CpfMae = table.Column<string>(type: "text", nullable: false),
                    casamentoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conjuges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conjuges_Casamentos_casamentoId",
                        column: x => x.casamentoId,
                        principalTable: "Casamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nascimentoId = table.Column<int>(type: "integer", nullable: false),
                    casamentoId = table.Column<int>(type: "integer", nullable: false),
                    obitoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registros_Casamentos_casamentoId",
                        column: x => x.casamentoId,
                        principalTable: "Casamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registros_Nascimentos_nascimentoId",
                        column: x => x.nascimentoId,
                        principalTable: "Nascimentos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registros_Obitos_obitoId",
                        column: x => x.obitoId,
                        principalTable: "Obitos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conjuges_casamentoId",
                table: "Conjuges",
                column: "casamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_casamentoId",
                table: "Registros",
                column: "casamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_nascimentoId",
                table: "Registros",
                column: "nascimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_obitoId",
                table: "Registros",
                column: "obitoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conjuges");

            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "Casamentos");

            migrationBuilder.DropTable(
                name: "Nascimentos");

            migrationBuilder.DropTable(
                name: "Obitos");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevTur.API.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bairro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    cep = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    complemento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    logradouro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    numero = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    uf = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    senha = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    datanascimento = table.Column<DateTime>(name: "data_nascimento", type: "date", nullable: false),
                    email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    enderecoidfk = table.Column<long>(name: "endereco_id_fk", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.id);
                    table.ForeignKey(
                        name: "cliente$FK45yfh6c2tecmc3h1e2672l7t6",
                        column: x => x.enderecoidfk,
                        principalTable: "endereco",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "funcionario",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpf = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    datanascimento = table.Column<DateTime>(name: "data_nascimento", type: "date", nullable: false),
                    email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    dataadmissao = table.Column<DateTime>(name: "data_admissao", type: "date", nullable: false),
                    datademissao = table.Column<DateTime>(name: "data_demissao", type: "date", nullable: true),
                    senha = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    enderecoidfk = table.Column<long>(name: "endereco_id_fk", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionario", x => x.id);
                    table.ForeignKey(
                        name: "funcionario$FKs4ik2nbyjsqnrb37ubwmkdyt8",
                        column: x => x.enderecoidfk,
                        principalTable: "endereco",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "viagem",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datafim = table.Column<DateTime>(name: "data_fim", type: "date", nullable: true),
                    datainicio = table.Column<DateTime>(name: "data_inicio", type: "date", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gastos = table.Column<decimal>(type: "decimal(19,2)", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    orcamento = table.Column<decimal>(type: "decimal(19,2)", nullable: false),
                    clienteidfk = table.Column<long>(name: "cliente_id_fk", type: "bigint", nullable: false),
                    acompanhantes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_viagem", x => x.id);
                    table.ForeignKey(
                        name: "viagem$FKh2ia86xs9dvujq545myvga47o",
                        column: x => x.clienteidfk,
                        principalTable: "cliente",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "cliente$UK_cmxo70m08n43599l3h0h07cc6",
                table: "cliente",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "cliente$UK_r1u8010d60num5vc8fp0q1j2a",
                table: "cliente",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FK45yfh6c2tecmc3h1e2672l7t6",
                table: "cliente",
                column: "endereco_id_fk");

            migrationBuilder.CreateIndex(
                name: "FKs4ik2nbyjsqnrb37ubwmkdyt8",
                table: "funcionario",
                column: "endereco_id_fk");

            migrationBuilder.CreateIndex(
                name: "funcionario$UK_rxosr8731eb3gbnlbt2mqfan8",
                table: "funcionario",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "funcionario$UK_t45qja1wnv0hu1cdw6vqjljgy",
                table: "funcionario",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FKh2ia86xs9dvujq545myvga47o",
                table: "viagem",
                column: "cliente_id_fk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "funcionario");

            migrationBuilder.DropTable(
                name: "viagem");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "endereco");
        }
    }
}

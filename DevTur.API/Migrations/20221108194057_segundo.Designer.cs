// <auto-generated />
using System;
using DevTur.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DevTur.API.Migrations
{
    [DbContext(typeof(DEVTURContext))]
    [Migration("20221108194057_segundo")]
    partial class segundo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DevTur.API.Models.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)")
                        .HasColumnName("cpf");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("email");

                    b.Property<long>("EnderecoIdFk")
                        .HasColumnType("bigint")
                        .HasColumnName("endereco_id_fk");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("senha");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "EnderecoIdFk" }, "FK45yfh6c2tecmc3h1e2672l7t6");

                    b.HasIndex(new[] { "Email" }, "cliente$UK_cmxo70m08n43599l3h0h07cc6")
                        .IsUnique();

                    b.HasIndex(new[] { "Cpf" }, "cliente$UK_r1u8010d60num5vc8fp0q1j2a")
                        .IsUnique();

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("DevTur.API.Models.Endereco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("complemento");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("numero");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)")
                        .HasColumnName("uf");

                    b.HasKey("Id");

                    b.ToTable("endereco");
                });

            modelBuilder.Entity("DevTur.API.Models.Funcionario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)")
                        .HasColumnName("cpf");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("date")
                        .HasColumnName("data_admissao");

                    b.Property<DateTime?>("DataDemissao")
                        .HasColumnType("date")
                        .HasColumnName("data_demissao");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("email");

                    b.Property<long>("EnderecoIdFk")
                        .HasColumnType("bigint")
                        .HasColumnName("endereco_id_fk");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("senha");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "EnderecoIdFk" }, "FKs4ik2nbyjsqnrb37ubwmkdyt8");

                    b.HasIndex(new[] { "Cpf" }, "funcionario$UK_rxosr8731eb3gbnlbt2mqfan8")
                        .IsUnique();

                    b.HasIndex(new[] { "Email" }, "funcionario$UK_t45qja1wnv0hu1cdw6vqjljgy")
                        .IsUnique();

                    b.ToTable("funcionario");
                });

            modelBuilder.Entity("DevTur.API.Models.Viagem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Acompanhantes")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("acompanhantes");

                    b.Property<long>("ClienteIdFk")
                        .HasColumnType("bigint")
                        .HasColumnName("cliente_id_fk");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("date")
                        .HasColumnName("data_fim");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("date")
                        .HasColumnName("data_inicio");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descricao");

                    b.Property<decimal>("Gastos")
                        .HasColumnType("decimal(19, 2)")
                        .HasColumnName("gastos");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("nome");

                    b.Property<decimal>("Orcamento")
                        .HasColumnType("decimal(19, 2)")
                        .HasColumnName("orcamento");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ClienteIdFk" }, "FKh2ia86xs9dvujq545myvga47o");

                    b.ToTable("viagem");
                });

            modelBuilder.Entity("DevTur.API.Models.Cliente", b =>
                {
                    b.HasOne("DevTur.API.Models.Endereco", "EnderecoIdFkNavigation")
                        .WithMany("Cliente")
                        .HasForeignKey("EnderecoIdFk")
                        .IsRequired()
                        .HasConstraintName("cliente$FK45yfh6c2tecmc3h1e2672l7t6");

                    b.Navigation("EnderecoIdFkNavigation");
                });

            modelBuilder.Entity("DevTur.API.Models.Funcionario", b =>
                {
                    b.HasOne("DevTur.API.Models.Endereco", "EnderecoIdFkNavigation")
                        .WithMany("Funcionario")
                        .HasForeignKey("EnderecoIdFk")
                        .IsRequired()
                        .HasConstraintName("funcionario$FKs4ik2nbyjsqnrb37ubwmkdyt8");

                    b.Navigation("EnderecoIdFkNavigation");
                });

            modelBuilder.Entity("DevTur.API.Models.Viagem", b =>
                {
                    b.HasOne("DevTur.API.Models.Cliente", "ClienteIdFkNavigation")
                        .WithMany("Viagem")
                        .HasForeignKey("ClienteIdFk")
                        .IsRequired()
                        .HasConstraintName("viagem$FKh2ia86xs9dvujq545myvga47o");

                    b.Navigation("ClienteIdFkNavigation");
                });

            modelBuilder.Entity("DevTur.API.Models.Cliente", b =>
                {
                    b.Navigation("Viagem");
                });

            modelBuilder.Entity("DevTur.API.Models.Endereco", b =>
                {
                    b.Navigation("Cliente");

                    b.Navigation("Funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DevTur.API.Models
{
    public partial class DEVTURContext : DbContext
    {
        public DEVTURContext()
        {
        }

        public DEVTURContext(DbContextOptions<DEVTURContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Funcionario> Funcionario { get; set; }
        public virtual DbSet<Viagem> Viagem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasOne(d => d.EnderecoIdFkNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.EnderecoIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cliente$FK45yfh6c2tecmc3h1e2672l7t6");
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasOne(d => d.EnderecoIdFkNavigation)
                    .WithMany(p => p.Funcionario)
                    .HasForeignKey(d => d.EnderecoIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("funcionario$FKs4ik2nbyjsqnrb37ubwmkdyt8");
            });

            modelBuilder.Entity<Viagem>(entity =>
            {
                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Viagem)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("viagem$FKh2ia86xs9dvujq545myvga47o");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
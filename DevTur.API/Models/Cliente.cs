﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevTur.API.Models
{
    [Table("cliente")]
    [Index("EnderecoIdFk", Name = "FK45yfh6c2tecmc3h1e2672l7t6")]
    [Index("Email", Name = "cliente$UK_cmxo70m08n43599l3h0h07cc6", IsUnique = true)]
    [Index("Cpf", Name = "cliente$UK_r1u8010d60num5vc8fp0q1j2a", IsUnique = true)]
    public partial class Cliente
    {
        public Cliente()
        {
            Viagem = new HashSet<Viagem>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("senha")]
        [StringLength(255)]
        public string Senha { get; set; }
        [Required]
        [Column("cpf")]
        [StringLength(14)]
        public string Cpf { get; set; }
        [Column("data_nascimento", TypeName = "date")]
        public DateTime DataNascimento { get; set; }
        [Required]
        [Column("email")]
        [StringLength(80)]
        public string Email { get; set; }
        [Required]
        [Column("nome")]
        [StringLength(80)]
        public string Nome { get; set; }
        [Required]
        [Column("telefone")]
        [StringLength(15)]
        public string Telefone { get; set; }
        [Column("endereco_id_fk")]
        public long EnderecoIdFk { get; set; }

        [ForeignKey("EnderecoIdFk")]
        [InverseProperty("Cliente")]
        public virtual Endereco EnderecoIdFkNavigation { get; set; }
        [InverseProperty("ClienteIdFkNavigation")]
        public virtual ICollection<Viagem> Viagem { get; set; }
    }
}
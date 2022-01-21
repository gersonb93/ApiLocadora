using ApiLocadora.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiLocadora.Model
{
    public class Cliente : BaseEntity
    {
        [StringLength(200)]
        public string Nome { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }
      
        public DateTime DataNascimento { get; set; }

        public ICollection<Locacao> Locacoes { get; set; } = new List<Locacao>();

        public Cliente(string nome, string cPF, DateTime dataNascimento)
        {
            Nome = nome;
            CPF = cPF;
            DataNascimento = dataNascimento;
        }
    }
}

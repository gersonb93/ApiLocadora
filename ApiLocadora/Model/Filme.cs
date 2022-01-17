using ApiLocadora.Model.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiLocadora.Model
{
    public class Filme : BaseEntity
    {
        [StringLength(100)]
        public string Titulo { get; set; }
        public int ClassificacaoIndicativa { get; set; }
        public byte Lancamento { get; set; }

        public virtual ICollection<Locacao> Locacoes { get; set; }

        public Filme(string titulo, int classificacaoIndicativa, byte lancamento)
        {
            Titulo = titulo;
            ClassificacaoIndicativa = classificacaoIndicativa;
            Lancamento = lancamento;
        }
    }
}

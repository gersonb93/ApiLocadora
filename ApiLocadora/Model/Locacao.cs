using ApiLocadora.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiLocadora.Model
{
    public class Locacao : BaseEntity
    {
        
        [Column("Id_Cliente")] 
        public virtual Cliente Cliente { get; set; }

        [Column("Id_Filme")]
        public virtual Filme Filme { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }

       
    }
}

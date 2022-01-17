using System.ComponentModel.DataAnnotations.Schema;

namespace ApiLocadora.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}

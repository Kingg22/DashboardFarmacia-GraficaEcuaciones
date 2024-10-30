using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaRey.models
{
    [Table("ventas")]
    public class Venta
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Column("fecha", TypeName = "timestamp")]
        public DateTime Fecha { get; set; }

        [Column("total", TypeName = "money")]
        public decimal Total {  get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaRey.models
{
    [Table("detalles_venta")]
    public class DetalleVenta
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [Column("venta")]
        public Guid VentaId { get; set; }

        [Required]
        [Column("medicamento")]
        public Guid MedicamentoId { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        [Column("cantidad")]
        public int Cantidad { get; set; }

        [Column("sub_total", TypeName = "money")]
        public decimal SubTotal { get; set; }

        [ForeignKey("VentaId")]
        public virtual Venta Venta { get; set; }

        [ForeignKey("MedicamentoId")]
        public virtual Medicamento Medicamento { get; set; }
    }
}

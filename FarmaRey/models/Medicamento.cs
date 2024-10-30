using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaRey.models
{
    [Table("medicamentos")]
    public class Medicamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [Column("nombre")]
        [StringLength(150)]
        public required string Nombre { get; set; }

        [Column("cantidad_disponible")]
        [Range(0, int.MaxValue)]
        public int CantidadDisponible { get; set; }

        [Column("precio_unidad", TypeName = "money")]
        public decimal PrecioUnidad { get; set; }

        [Column("imagen_data", TypeName = "bytea")]
        public byte[]? ImagenData { get; set; }

        [Column("categoria")]
        public Guid? CategoriaId { get; set; }

        [Column("created_at", TypeName = "timestamp")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey("CategoriaId")]
        public virtual Categoria Categoria { get; set; }
    }
}

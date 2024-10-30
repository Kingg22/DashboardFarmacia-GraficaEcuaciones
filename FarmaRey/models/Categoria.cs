using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaRey.models
{
    [Table("categorias")]
    public class Categoria
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [Column("nombre")]
        [StringLength(100)]
        public required string Nombre { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libreria.Core.Entities
{
    [Table("autores_has_libros")]
    public class AutorLibro
    {

        [Column("autores_id")]
        [Key]
        public int AutorId { get; set; }
        public Autor Autor { get; set; }

        [Column("libros_ISBN")]
        [Key]
        public int LibroId { get; set; }
        public Libro Libro { get; set; }

    }
}

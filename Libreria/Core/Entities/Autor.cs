using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libreria.Core.Entities
{
    [Table("autores")]
    public class Autor
    {
        [Column("id")]
        [Key]
        public int AutorId { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("apellidos")]
        public string Apellidos { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        public List<AutorLibro> AutorLibro { get; set; }
    }
}

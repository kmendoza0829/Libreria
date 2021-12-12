using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libreria.Core.Entities
{
    [Table("editoriales")]
    public class Editorial
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("sede")]
        public string Sede { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libreria.Core.Entities
{
    [Table("usuarios")]
    public class Usuarios
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("username")]
        public string Username { get; set; }

        [Column("password")] 
        public string Password { get; set; }
}
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libreria.Core.Entities
{
    [Table("libros")]
    public class Libro
    {
        [Column("ISBN")]
        [Key]
        public int LibrosId { get; set; }

        [Column("titulo")]
        public string Titulo { get; set; }

        [Column("sinopsis")]
        public string Sinopsis { get; set; }

        [Column("n_paginas")]
        public int NPaginas { get; set; }

        [Column("editoriales_id")]
        public int EditorialId { get; set; }

        public Editorial Editorial { get; set; }
    }
}

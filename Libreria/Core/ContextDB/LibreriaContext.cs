using Libreria.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Core.ContextDB
{
    public class LibreriaContext :DbContext
    {
        public LibreriaContext(DbContextOptions<LibreriaContext> options) : base(options)
        {
            
        }
        public DbSet<Editorial> Editorial { get; set; }
    }
}

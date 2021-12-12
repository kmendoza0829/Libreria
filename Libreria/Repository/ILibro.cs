using Libreria.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Libreria.Repository
{
    public interface ILibro
    {
        Task<IEnumerable<Libro>> GetLibroAsync();
        Task<Libro> GetLibrossByIdAsync(int id);
        Task<Libro> CreateLibrosAsync(Libro libro);
        Task DeleteLibrosAsync(int id);
        Task<Libro> EditLbrosAsync(int id, Libro libro);
    }
}

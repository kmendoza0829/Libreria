using Libreria.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Libreria.Repository
{
    public interface IAutorLibro
    {
        Task<IEnumerable<AutorLibro>> GetAutorLibrosAsync();
        Task<AutorLibro> GetAutorLibroByIdAutorAsync(int id);
        Task<AutorLibro> GetAutorLibroByIdLibroAsync(int id);

        Task<AutorLibro> CreateAutorLibroAsync(AutorLibro autorLibro);
    }
}

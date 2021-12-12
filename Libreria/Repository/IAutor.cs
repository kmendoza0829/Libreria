using Libreria.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Libreria.Repository
{
    public interface IAutor
    {
        Task<IEnumerable<Autor>> GetAutoresAsync();
        Task<Autor> GetAutoresByIdAsync(int id);
        Task<Autor> CreateAutorAsync(Autor autor);
        Task DeleteAutorAsync(int id);
        Task<Autor> EditAutorAsync(int id, Autor autor);
    }
}
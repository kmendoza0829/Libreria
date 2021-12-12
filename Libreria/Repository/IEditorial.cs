using Libreria.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Libreria.Repository
{
    public interface IEditorial
    {
        Task<IEnumerable<Editorial>> GetEditorialesAsync();
        Task<Editorial> GetEditorialesByIdAsync(int id);
        Task<Editorial> CreateEditorialAsync(Editorial editorial);
        Task DeleteEditorialAsync(int id);
        Task<Editorial> EditEditorialAsync(int id, Editorial editorial);
    }
}

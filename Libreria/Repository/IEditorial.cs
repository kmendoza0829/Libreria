using Libreria.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Libreria.Repository
{
    public interface IEditorial
    {
        Task<IEnumerable<Editorial>> GetEditorialesAsync();
    }
}

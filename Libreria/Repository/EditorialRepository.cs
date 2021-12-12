using Libreria.Core.ContextDB;
using Libreria.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Libreria.Repository
{
    public class EditorialRepository : IEditorial
    {
        private readonly LibreriaContext _dbContext;

        public EditorialRepository(LibreriaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Editorial>> GetEditorialesAsync()
        {
            return await _dbContext.Editorial.ToListAsync();
        }
    }
}

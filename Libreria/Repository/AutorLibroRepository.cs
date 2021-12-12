using Libreria.Core.ContextDB;
using Libreria.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libreria.Repository
{
    public class AutorLibroRepository : IAutorLibro
    {
        private readonly LibreriaContext _dbContext;

        public AutorLibroRepository(LibreriaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AutorLibro> CreateAutorLibroAsync(AutorLibro autorLibro)
        {
            try
            {
                await _dbContext.AddAsync(autorLibro);
                _dbContext.SaveChanges();
                return autorLibro;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<AutorLibro> GetAutorLibroByIdAutorAsync(int id)
        {
            try
            {
                return await _dbContext.AutorLibro
                    .Include(a => a.Autor)
                    .Include(a => a.Libro)
                    .Where(a => a.AutorId == id).FirstOrDefaultAsync();
            }
            catch (System.Exception)
            {

                throw;
            }

            
        }

        public async Task<AutorLibro> GetAutorLibroByIdLibroAsync(int id)
        {
            try
            {
                return await _dbContext.AutorLibro
                    .Include(a => a.Autor)
                    .Include(a => a.Libro)
                    .Where(a => a.LibroId == id).FirstOrDefaultAsync();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<AutorLibro>> GetAutorLibrosAsync()
        {
            try
            {
                return await _dbContext.AutorLibro
                    .Include(a => a.Autor)
                    .Include(a => a.Libro)
                    .AsNoTracking().ToListAsync();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}

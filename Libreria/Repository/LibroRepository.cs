using Libreria.Core.ContextDB;
using Libreria.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libreria.Repository
{
    public class LibroRepository : ILibro
    {
        private readonly LibreriaContext _dbContext;

        public LibroRepository(LibreriaContext dbContext)
        {
            _dbContext = dbContext;
        }


        /// <summary>
        /// Funcion para la creacion asincrona
        /// </summary>
        /// <param name="libro">Entidad a crear</param>
        /// <returns>Entidad Creada</returns>
        public async Task<Libro> CreateLibrosAsync(Libro libro)
        {
            try
            {
                await _dbContext.AddAsync(libro);
                _dbContext.SaveChanges();
                return libro;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public Task DeleteLibrosAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Funcion para editar
        /// </summary>
        /// <param name="id">Llave a editar</param>
        /// <param name="libro">Objeto a editar</param>
        /// <returns></returns>
        public async Task<Libro> EditLbrosAsync(int id, Libro libro)
        {
            try
            {
                Libro libroUp = await _dbContext.Libro.FindAsync(id);
                if(libroUp != null)
                {
                    libroUp.Titulo = libro.Titulo;
                    libroUp.Sinopsis = libro.Sinopsis;
                    libroUp.NPaginas = libro.NPaginas;
                    libroUp.EditorialId = libro.EditorialId;
                    _dbContext.SaveChanges();
                }
                
                return libroUp;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Libro>> GetLibroAsync()
        {

            try
            {
                return await _dbContext.Libro.Include(a => a.Editorial).AsNoTracking().ToListAsync();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<Libro> GetLibrossByIdAsync(int id)
        {
            try
            {
                return await _dbContext.Libro
                    .Include(a => a.Editorial)
                    .Where(a => a.LibrosId == id).FirstOrDefaultAsync();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}

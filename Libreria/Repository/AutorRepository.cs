using Libreria.Core.ContextDB;
using Libreria.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Libreria.Repository
{
    public class AutorRepository : IAutor
    {

        private readonly LibreriaContext _dbContext;


       
        public AutorRepository(LibreriaContext dbContext)
        {
            _dbContext = dbContext;
        }


        /// <summary>
        /// Funcion para la creacion asincrona de Autores
        /// </summary>
        /// <param name="autor">autor a crear</param>
        /// <returns>autor Creado</returns>
        public async Task<Autor> CreateAutorAsync(Autor autor)
        {
            try
            {
                await _dbContext.AddAsync(autor);
                _dbContext.SaveChanges();
                return autor;
            }
            catch (System.Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Funcion para cambiar de estado un autor
        /// </summary>
        /// <param name="id">Llave a actualizar</param>
        /// <returns></returns>
        public async Task DeleteAutorAsync(int id)
        {
            try
            {
                Autor autor = await _dbContext.Autor.FindAsync(id);
                autor.Status = false;

                _dbContext.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Funcion para editar una editorial
        /// </summary>
        /// <param name="id">llave a editar</param>
        /// <param name="autor">Objeto para actualizar</param>
        /// <returns>Objeto editado</returns>
        public async Task<Autor> EditAutorAsync(int id, Autor autor)
        {
            try
            {
                Autor actorUpdate = await _dbContext.Autor.FindAsync(id);
                actorUpdate.Nombre = autor.Nombre;
                actorUpdate.Apellidos = autor.Apellidos;
                actorUpdate.Status = autor.Status;
                _dbContext.SaveChanges();
                return actorUpdate;
            }
            catch (System.Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Obtener listado de Autores
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Autor>> GetAutoresAsync()
        {
            try
            {
                return await _dbContext.Autor.AsNoTracking().ToListAsync();
            }
            catch (System.Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Funcion para obtener un registro por su llave primaria
        /// </summary>
        /// <param name="id">Llave de Autor</param>
        /// <returns>Entidad encontrada</returns>
        public async Task<Autor> GetAutoresByIdAsync(int id)
        {
            try
            {
                return await _dbContext.Autor.FindAsync(id);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}

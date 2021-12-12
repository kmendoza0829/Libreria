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

        /// <summary>
        /// Funcion para la creacion asincrona de Editoriales
        /// </summary>
        /// <param name="editorial">Entidad a crear</param>
        /// <returns>Entidad Creada</returns>
        public async Task<Editorial> CreateEditorialAsync(Editorial editorial)
        {
            try
            {
                await _dbContext.AddAsync(editorial);
                _dbContext.SaveChanges();
                return editorial;
            }
            catch (System.Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Funcion para cambiar de estado una editorial
        /// </summary>
        /// <param name="id">LLave de registro a actualizar</param>
        /// <returns></returns>
        public async Task DeleteEditorialAsync(int id)
        {
            try
            {

                Editorial editorial =  await _dbContext.Editorial.FindAsync(id);
                editorial.Status = false;

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
        /// <param name="editorial">Objeto Editorial</param>
        /// <returns></returns>
        public async Task<Editorial> EditEditorialAsync(int id, Editorial editorial)
        {
            try
            {
                Editorial editorialUp = await _dbContext.Editorial.FindAsync(id);
                editorialUp.Nombre = editorial.Nombre;
                editorialUp.Sede = editorial.Sede;
                editorialUp.Status = editorial.Status;
                _dbContext.SaveChanges();
                return editorial;
            }
            catch (System.Exception)
            {

                throw;
            }
            
        }


        /// <summary>
        /// Obtener listado de editoriales
        /// </summary>
        /// <returns>List de Editoriales</returns>
        public async Task<IEnumerable<Editorial>> GetEditorialesAsync()
        {
            try
            {
                return await _dbContext.Editorial.AsNoTracking().ToListAsync();
            }
            catch (System.Exception)
            {

                throw;
            }
            
        }


        /// <summary>
        /// Funcion para obtener un registro por su llave primaria
        /// </summary>
        /// <param name="id">Llave de Editorial</param>
        /// <returns>Entidad encontrada</returns>
        public async Task<Editorial> GetEditorialesByIdAsync(int id)
        {
            try
            {
                return await _dbContext.Editorial.FindAsync(id);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}

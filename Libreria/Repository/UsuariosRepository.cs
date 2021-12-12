using Libreria.Core.ContextDB;
using Libreria.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Libreria.Repository
{
    public class UsuariosRepository : IUsuarios
    {
        private readonly LibreriaContext _dbContext;

        public UsuariosRepository(LibreriaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Usuarios> CreateUsuariosAsync(Usuarios usuarios)
        {
            try
            {
                await _dbContext.AddAsync(usuarios);
                _dbContext.SaveChanges();
                return usuarios;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public bool GetExitsUser(string user, string password)
        {
            return _dbContext.Usuarios.Where(a => a.Username == user && a.Password == password).Any();
        }

        public Usuarios GetUsuarioByIdAsync(string username)
        {
            Usuarios libroUp = _dbContext.Usuarios.Where(a => a.Username == username).FirstOrDefault();
            return libroUp;
        }
    }
}

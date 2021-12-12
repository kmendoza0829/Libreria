using Libreria.Core.Entities;
using System.Threading.Tasks;

namespace Libreria.Repository
{
    public interface IUsuarios
    {
        bool GetExitsUser(string user, string password);
        Task<Usuarios> CreateUsuariosAsync(Usuarios usuarios);

        Usuarios GetUsuarioByIdAsync(string username);
    }
}

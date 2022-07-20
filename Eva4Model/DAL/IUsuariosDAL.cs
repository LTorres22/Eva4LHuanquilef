using Eva4Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion4Model.DAL
{
    public interface IUsuariosDAL
    {
        List<Usuario> ObtenerUsuarios();
        List<Usuario> ObtenerUsuarios(string estado);
        Usuario Obtener(int IdUsuario);
        void AgregarUsuario(Usuario usuario);
        void EliminarUsuario(int IdUsuario);
    }
}

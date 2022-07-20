using Eva4Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion4Model.DAL
{
    public interface IMedidoresDAL
    {
        List<Medidor> ObtenerMedidores();
        List<Medidor> ObtenerMedidores(string tipoMedidor);
        Medidor Obtener(int IdMedidor);
        void AgregarMedidor(Medidor medidor);
        void EliminarMedidor(int IdMedidor);
    }
}

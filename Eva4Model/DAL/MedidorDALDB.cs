using Eva4Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion4Model.DAL
{
    public class MedidorDALDB : IMedidoresDAL
    {
        private EvaDB_4Entities eva4DB = new EvaDB_4Entities();

        public void AgregarMedidor(Medidor medidor)
        {
            this.eva4DB.Medidors.Add(medidor);
            this.eva4DB.SaveChanges();
        }

        public void EliminarMedidor(int IdMedidor)
        {
            Medidor medidor = this.eva4DB.Medidors.Find(IdMedidor);
            this.eva4DB.Medidors.Remove(medidor);
            this.eva4DB.SaveChanges();
        }

        public Medidor Obtener(int IdMedidor)
        {
            return eva4DB.Medidors.Find(IdMedidor);
        }

        public List<Medidor> ObtenerMedidores()
        {
            return this.eva4DB.Medidors.ToList();
        }

        public void Actualizar(Medidor m)
        {
            Medidor mOriginal = this.eva4DB.Medidors.Find(m.IdMedidor);
            mOriginal.Numero = m.Numero;
            mOriginal.TipoMedidor = m.TipoMedidor;
            mOriginal.IdUsuario = m.IdUsuario;
            this.eva4DB.SaveChanges();
        }

        public List<Medidor> ObtenerMedidores(string tipoMedidor)
        {
            var query = from m in this.eva4DB.Medidors
                        where m.TipoMedidor == tipoMedidor
                        select m;
            return query.ToList();
        }
    }
}

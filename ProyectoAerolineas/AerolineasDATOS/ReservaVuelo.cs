using AerolineasENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasDATOS
{
   public  class ReservaVuelo
    {


        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(ReservaVuelos Rvuelo)
        {
            var sql =
                "INSERT INTO ReservaVuelo (origen destino salida llegada ppasajeros id_TarifaVuelo) VALUES ('" + Rvuelo.Origen + "', '" +
                Rvuelo.Destino+ "', '" +
                Rvuelo.salida+ "', '" +
                Rvuelo.llegada+ "', '" +
                Rvuelo.Pasajeros + "', '" +
                Rvuelo.fk_TarifaVuelo + "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(ReservaVuelos Rvuelo)
        {
            var sql =
                "UPDATE ReservaVuelo SET origen = '" + Rvuelo.Origen + "', destino = '" + Rvuelo.Destino + "', salida = '" + Rvuelo.salida
                + "', llegada = '" + Rvuelo.llegada + "', pasajeros = '" + Rvuelo.Pasajeros + "' WHERE id = '" +
                Rvuelo.Identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(int id)
        {
            var sql = "DELETE FROM ReservaVuelo WHERE id = '" + id + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }




    }
}

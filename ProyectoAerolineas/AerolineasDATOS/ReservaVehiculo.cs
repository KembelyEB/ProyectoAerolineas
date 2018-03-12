using AerolineasENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasDATOS
{
    public class ReservaVehiculo
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(ReservasVehiculo Rvehiculo)
        {
            var sql =
                "INSERT INTO reservaVehiculo (tipoauto, retira, entrega, id_Vehiculo) VALUES ('" + Rvehiculo.tipoAuto + "', '" +
                Rvehiculo.Retira + "', '" +
                Rvehiculo.Entrega+ "', '" +
                Rvehiculo.id_Vehiculos +  "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(ReservasVehiculo Rvehiculo)
        {
            var sql =
                "UPDATE reservaVehiculo SET tipoauto = '" + Rvehiculo.tipoAuto + "', retira = '" + Rvehiculo.Retira + "', entrega = '" + Rvehiculo.Entrega
                + "', id_Vehiculo = '" + Rvehiculo.id_Vehiculos + "' WHERE id = '" +
                Rvehiculo.id + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(int id)
        {
            var sql = "DELETE FROM reservaVehiculo WHERE id = '" + id + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }






    }
}

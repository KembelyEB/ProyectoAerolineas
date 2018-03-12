using AerolineasENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasDATOS
{
    public class ReservasDA
    {

        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(Reservas reservas)
        {
            var sql =
                "INSERT INTO reserva (id_usuario, id_vuelo, id_hotel, id_vehiculo ) VALUES ('" + reservas.id_Usuario + "', '" +
                reservas.id_Vuelo + "', '" +
                reservas.id_Hotel + "', '" +
                reservas.id_Vehiculo+ "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(Reservas reservas)
        {
            var sql =
                "UPDATE reserva SET id_usuario = '" + reservas.id_Usuario + "', id_vuelo = '" + reservas.id_Vuelo + "', id_hotel= '" + reservas.id_Hotel
                + "', id_vehiculo = '" + reservas.id_Vehiculo + "' WHERE id = '" +
                reservas.id + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(int id)
        {
            var sql = "DELETE FROM reserva WHERE id = '" + id + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }



    }
}

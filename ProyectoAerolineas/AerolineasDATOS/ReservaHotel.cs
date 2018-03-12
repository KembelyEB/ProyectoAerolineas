using AerolineasENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasDATOS
{
   public  class ReservaHotel
    {

        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(ReservasHotel Rhotel)
        {
            var sql =
                "INSERT INTO reservaHotel ( destino, entrada, salida, habitaciones,  id_Hotel) VALUES ('" + Rhotel.destino+ "', '" +
                Rhotel.destino + "', '" +
                Rhotel.entrada + "', '" +
                Rhotel.salida+ "', '" +
                Rhotel.habitaciones + "', '" +
                Rhotel.id_Hotels + "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(ReservasHotel Rhotel)
        {
            var sql =
                "UPDATE reservaHotel SET destino= '" + Rhotel.destino+ "', entrada= '" + Rhotel.entrada + "', salida = '" + Rhotel.salida
                + "', habitaciones = '" + Rhotel.habitaciones+  "' WHERE id = '" +
                Rhotel.id_Hotels + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(int id)
        {
            var sql = "DELETE FROM rfeservaHotel WHERE id = '" + id + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }




    }
}

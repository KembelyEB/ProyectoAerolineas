using AerolineasENTIDADES;
using Npgsql;
using System.Collections.Generic;

namespace AerolineasDATOS
{
    /// <summary>
    /// this class makes the connection to database about hotels
    /// </summary>
    public class HotelesDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();
        /// <summary>
        /// this method inserts a hotel object into the database
        /// </summary>
        /// <param name="hotel"></param>
        public void InsertarDatos(Hotel hotel)
        {
            var sql = "INSERT INTO hoteles (identificador, nombre, foto, pais, lugar, habitaciones) VALUES ('" +
                      hotel.Identificador + "', '" + hotel.Nombre + "', '" + hotel.Foto + "', '" + hotel.Pais + "', '" + hotel.Lugar + "', '" +
                      hotel.Habitacion + "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// this method modifies a hotel object into the database
        /// </summary>
        public void ModificarDatos(Hotel hotel)
        {
            var sql = "UPDATE hoteles SET nombre = '" + hotel.Nombre + "', foto = '" + hotel.Foto + "', pais = '" + hotel.Pais +
                      "', lugar= '" +
                      hotel.Lugar + "', habitaciones = '" + hotel.Habitacion + "' WHERE identificador = '" + hotel.Identificador + "'";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// this method removes a hotel object into the database
        /// </summary>
        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM hoteles WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }



        public void Consultar(string identificador)
        {
            var connectioStringProvider = new ConnectionStringProvider();
            var connection = new NpgsqlConnection(connectioStringProvider.GetConnectionString());
            List<object> lista = new List<object>();

            var command = new NpgsqlCommand ("SELECT nombre FROM hotel", connection);
            NpgsqlDataReader dr = command.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                    lista.Add(dr.GetString(1));
                    lista.Add(dr.GetString(2));
                    lista.Add(dr.GetString(3));
                    lista.Add(dr.GetString(4));
                    lista.Add(dr.GetString(5));
                }
            }
            connection.Close();         
        }
    }

}
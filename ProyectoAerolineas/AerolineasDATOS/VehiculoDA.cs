using AerolineasENTIDADES;
using Npgsql;
using System.Collections.Generic;

namespace AerolineasDATOS
{
    /// <summary>
    /// this class makes the connection to database about cars
    /// </summary>
    public class VehiculoDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        /// <summary>
        /// this method inserts a car object into the database
        /// </summary>
        public void InsertarDatos(Vehiculo vehiculo)
        {
            var sql =
                "INSERT INTO vehiculo (identificador, marca, modelo, tipo, precio, cantidad) VALUES ('" +
                 vehiculo.Identificador + "', '" + vehiculo.Marca + "', '" + vehiculo.Modelo + "', '" + vehiculo.Tipo + "', '" + vehiculo.Precio + "', '" + vehiculo.Cantidad +
                "')";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// this method modifies a car object into the database
        /// </summary>
        public void ModificarDatos(Vehiculo vehiculo)
        {
            var sql =
                "UPDATE vehiculo SET marca = '" + vehiculo.Marca + "', modelo = '" + vehiculo.Modelo + "', tipo = '" + vehiculo.Tipo +
                "', precio= '" + vehiculo.Precio + "', cantidad = '" + vehiculo.Cantidad + "' WHERE identificador = '" + vehiculo.Identificador +
                "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// this method removes a car object into the database
        /// </summary>
        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM vehiculo WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }


        public void Consultar()
        {


            var connectioStringProvider = new ConnectionStringProvider();
            var connection = new NpgsqlConnection(connectioStringProvider.GetConnectionString());
            List<object> lista = new List<object>();

            var command = new NpgsqlCommand("SELECT marca FROM vehiculo", connection);
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
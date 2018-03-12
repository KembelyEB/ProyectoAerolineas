using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    /// <summary>
    /// this class makes the connection to database about flight rates
    /// </summary>
    public class TarifaVueloDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        /// <summary>
        /// this method inserts a flight rates object into the database
        /// </summary>
        public void InsertarDatos(TarifaVuelo tarifaVuelo)
        {
            var sql = "INSERT INTO tarifavuelos (id, ruta, precio) VALUES ('" + tarifaVuelo.Identificador + "', '" + tarifaVuelo.Ruta +
                      "', '" +
                       tarifaVuelo.Precio + "')";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// this method modifies a flight rates object into the database
        /// </summary>
        public void ModificarDatos(TarifaVuelo tarifaVuelo)
        {
            var sql =
                "UPDATE tarifavuelos SET ruta = '" + tarifaVuelo.Ruta + "', precio = '" + tarifaVuelo.Precio + "' WHERE id = '" +
                 tarifaVuelo.Identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }


        /// <summary>
        /// this method removes a flight rates object into the database
        /// </summary>
        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM tarifavuelos WHERE id = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    public class TarifaVueloDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(TarifaVuelo tarifaVuelo)
        {
            var sql = "INSERT INTO vuelo (identificador, ruta, precio) VALUES ('" + identificador + "', '" + ruta +
                      "', '" +
                      precio + "')";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(TarifaVuelo tarifaVuelo)
        {
            var sql =
                "UPDATE vuelo SET ruta = '" + ruta + "', precio = '" + precio + "' WHERE identificador = '" +
                identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM vuelo WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
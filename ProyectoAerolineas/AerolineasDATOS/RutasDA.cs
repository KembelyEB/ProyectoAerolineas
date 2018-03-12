using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    /// <summary>
    /// this class makes the connection to database about routes
    /// </summary>
    public class RutasDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        /// <summary>
        /// this method inserts a route object into the database
        /// </summary>
        public void InsertarDatos(Ruta ruta)
        {
            var sql = "INSERT INTO rutas (pais_origen, pais_destino, duracion) VALUES ('" +
                      ruta.Identificador +
                      "', '" + ruta.Pais_Origen + "', '" + ruta.Pais_Destino + "', '" + ruta.Duracion + "')";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// this method modifies a route object into the database
        /// </summary>
        public void ModificarDatos(Ruta ruta)
        {
            var sql = "UPDATE rutas SET pais_origen = '" + ruta.Pais_Origen + "', pais_destino = '" + ruta.Pais_Destino + "', duracion = '" +
                     ruta.Duracion + "' WHERE id = '" + ruta.Identificador + "'";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// this method removes a route object into the database
        /// </summary>
        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM rutas WHERE id = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
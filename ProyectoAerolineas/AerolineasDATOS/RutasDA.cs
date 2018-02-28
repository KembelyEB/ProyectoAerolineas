using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    public class RutasDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(Ruta ruta)
        {
            var sql = "INSERT INTO ruta (identificador, pais_origen, pais_destino, duracion) VALUES ('" +
                      ruta.Identificador +
                      "', '" + ruta.Pais_Origen + "', '" + ruta.Pais_Destino + "', '" + ruta.Duracion + "')";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(Ruta ruta)
        {
            var sql = "UPDATE ruta SET pais_origen = '" + ruta.Pais_Origen + "', pais_destino = '" + ruta.Pais_Destino + "', duracion = '" +
                     ruta.Duracion + "' WHERE identificador = '" + ruta.Identificador + "'";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM ruta WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
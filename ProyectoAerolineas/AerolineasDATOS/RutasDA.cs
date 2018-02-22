namespace AerolineasDATOS
{
    public class RutasDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(string identificador, string origen, string destino, string duracion)
        {
            var sql = "INSERT INTO ruta (identificador, pais_origen, pais_destino, duracion) VALUES ('" +
                      identificador +
                      "', '" + origen + "', '" + destino + "', '" + duracion + "')";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(string identificador, string origen, string destino, string duracion)
        {
            var sql = "UPDATE ruta SET pais_origen = '" + origen + "', pais_destino = '" + destino + "', duracion = '" +
                      duracion + "' WHERE identificador = '" + identificador + "'";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM ruta WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
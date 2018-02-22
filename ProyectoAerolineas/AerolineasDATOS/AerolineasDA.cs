using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    public class AerolineasDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(Aerolinea aerolinea)
        {
            var sql = "INSERT INTO aerolineas (identificador, nombre) VALUES ('" + aerolinea.Identificador + "', '" +
                      aerolinea.Nombre +
                      "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(Aerolinea aerolinea)
        {
            var sql = "UPDATE aerolineas SET nombre = '" + aerolinea.Nombre + "' WHERE identificador = '" +
                      aerolinea.Identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM aerolineas WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
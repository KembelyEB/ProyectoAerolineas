using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    public class PaisesDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(Pais pais)
        {
            var sql = "INSERT INTO paises (identificador, nombre, bandera) VALUES ('" + identificador + "', '" +
                      nombre +
                      "', '" + bandera + "')";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(Pais pais)
        {
            var sql = "UPDATE paises SET nombre = '" + nombre + "', bandera = '" + bandera +
                      "' WHERE identificador = '" +
                      identificador + "'";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM paises WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    public class PaisesDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(Pais pais)
        {
            var sql = "INSERT INTO paises (identificador, nombre, bandera) VALUES ('" + pais.Identificador + "', '" +
                      pais.Nombre +
                      "', '" + pais.Bandera + "')";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(Pais pais)
        {
            var sql = "UPDATE paises SET nombre = '" + pais.Nombre + "', bandera = '" + pais.Bandera +
                      "' WHERE identificador = '" +
                      pais.Identificador + "'";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM paises WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
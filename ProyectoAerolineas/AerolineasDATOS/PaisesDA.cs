using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    /// <summary>
    /// this class makes the connection to database about countries
    /// </summary>
    public class PaisesDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        /// <summary>
        /// this method inserts a country object into the database
        /// </summary>
        public void InsertarDatos(Pais pais)
        {
            var sql = "INSERT INTO paises (identificador, nombre, bandera) VALUES ('" + pais.Identificador + "', '" +
                      pais.Nombre +
                      "', '" + pais.Bandera + "')";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// this method modifies a country object into the database
        /// </summary>
        public void ModificarDatos(Pais pais)
        {
            var sql = "UPDATE paises SET nombre = '" + pais.Nombre + "', bandera = '" + pais.Bandera +
                      "' WHERE identificador = '" +
                      pais.Identificador + "'";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// this method removes a country object into the database
        /// </summary>
        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM paises WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
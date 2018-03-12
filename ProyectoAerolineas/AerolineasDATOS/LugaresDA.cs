using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    /// <summary>
    /// this class makes the connection to database about places
    /// </summary>
    public class LugaresDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        /// <summary>
        /// this method inserts a place object into the database
        /// </summary>
        public void InsertarDatos(Lugar lugar)
        {
            var sql = "INSERT INTO lugares (id, nombre) VALUES ('" + lugar.Identificador + "', '" + lugar.Nombre + "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// this method modifies a place object into the database
        /// </summary>
        public void ModificarDatos(Lugar lugar)
        {
            var sql = "UPDATE lugares SET nombre = '" + lugar.Nombre + "' WHERE id = '" + lugar.Identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// this method removes a place object into the database
        /// </summary>
        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM lugares WHERE id = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
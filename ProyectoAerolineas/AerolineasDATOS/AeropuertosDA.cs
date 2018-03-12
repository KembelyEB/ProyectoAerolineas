using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    /// <summary>
    /// this class makes the connection to database about airports
    /// </summary>
    public class AeropuertosDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();
        /// <summary>
        /// this method inserts an airport object into the database
        /// </summary>
        /// <param name="aeropuerto"></param>
        public void InsertarDatos(Aeropuerto aeropuerto)
        {
            var sql = "INSERT INTO aeropuertos (identificador, nombre, localidad, iata ) VALUES ('" + aeropuerto.Identificador +
                      "', '" + aeropuerto.Nombre + "', '" + aeropuerto.Localidad + "', '" + aeropuerto.Iata + "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// this method modifies an airport object into the database
        /// </summary>
        /// <param name="aeropuerto"></param>
        public void ModificarDatos(Aeropuerto aeropuerto)
        {
            var sql = "UPDATE aeropuertos SET nombre = '" + aeropuerto.Nombre + "', localidad = '" + aeropuerto.Localidad + "', iata = '" +
                      aeropuerto.Iata+ "' WHERE identificador = '" + aeropuerto.Identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// this method removes an airport object into the database
        /// </summary>
        /// <param name="identificador"></param>
        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM aeropuertos WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
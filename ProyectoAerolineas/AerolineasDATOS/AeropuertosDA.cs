using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    public class AeropuertosDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(Aeropuerto aeropuerto)
        {
            var sql = "INSERT INTO aeropuertos (identificador, nombre, localidad, iata ) VALUES ('" + identificador +
                      "', '" + nombre + "', '" + localidad + "', '" + IATA + "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(Aeropuerto aeropuerto)
        {
            var sql = "UPDATE aeropuertos SET nombre = '" + nombre + "', localidad = '" + localidad + "', iata = '" +
                      IATA + "' WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM aeropuertos WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    public class AeropuertosDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(Aeropuerto aeropuerto)
        {
            var sql = "INSERT INTO aeropuertos (identificador, nombre, localidad, iata ) VALUES ('" + aeropuerto.Identificador +
                      "', '" + aeropuerto.Nombre + "', '" + aeropuerto.Localidad + "', '" + aeropuerto.Iata + "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(Aeropuerto aeropuerto)
        {
            var sql = "UPDATE aeropuertos SET nombre = '" + aeropuerto.Nombre + "', localidad = '" + aeropuerto.Localidad + "', iata = '" +
                      aeropuerto.Iata+ "' WHERE identificador = '" + aeropuerto.Identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM aeropuertos WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
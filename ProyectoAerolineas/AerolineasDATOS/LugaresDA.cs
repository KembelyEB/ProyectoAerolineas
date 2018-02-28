using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    public class LugaresDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(Lugar lugar)
        {
            var sql = "INSERT INTO lugares (identificador, nombre) VALUES ('" + lugar.Identificador + "', '" + lugar.Nombre + "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(Lugar lugar)
        {
            var sql = "UPDATE lugares SET nombre = '" + lugar.Nombre + "' WHERE identificador = '" + lugar.Identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM lugares WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    /// <summary>
    /// this class makes the connection to database about hotel rates
    /// </summary>
    public class TarifasHotelesDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        /// <summary>
        /// this method inserts a hotel rate object into the database
        /// </summary>
        public void InsertarDatos(TarifaHotel tarifaHotel)
        {
            var sql =
                "INSERT INTO tarifahoteles (id, precio) VALUES ('" + tarifaHotel.Identificador + "', '" + tarifaHotel.Precio +
                "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// this method modifies a hotel rate object into the database
        /// </summary>
        public void ModificarDatos(TarifaHotel tarifaHotel)
        {
            var sql =
                "UPDATE tarifahoteles SET precio = '" + tarifaHotel.Precio + "' WHERE id = '" + tarifaHotel.Identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// this method removes a hotel rate object into the database
        /// </summary>
        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM tarifahoteles WHERE id = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
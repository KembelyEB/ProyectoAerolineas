namespace AerolineasDATOS
{
    public class HotelesDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(string identificador, string nombre, byte foto, string pais, string lugar,
            int habitaciones)
        {
            var sql = "INSERT INTO hoteles (identificador, nombre, foto, pais, lugar, habitaciones) VALUES ('" +
                      identificador + "', '" + nombre + "', '" + foto + "', '" + pais + "', '" + lugar + "', '" +
                      habitaciones + "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(string identificador, string nombre, byte foto, string pais, string lugar,
            int habitaciones)
        {
            var sql = "UPDATE hoteles SET nombre = '" + nombre + "', foto = '" + foto + "', pais = '" + pais +
                      "', lugar= '" +
                      lugar + "', habitaciones = '" + habitaciones + "' WHERE identificador = '" + identificador + "'";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM hoteles WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
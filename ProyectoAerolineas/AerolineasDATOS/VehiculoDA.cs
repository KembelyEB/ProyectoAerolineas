namespace AerolineasDATOS
{
    public class VehiculoDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(string identificador, string marca, string modelo, string tipo, int precio,
            int cantidad)
        {
            var sql =
                "INSERT INTO vehiculo (identificador, marca, modelo, tipo, precio, cantidad) VALUES ('" +
                identificador + "', '" + marca + "', '" + modelo + "', '" + tipo + "', '" + precio + "', '" + cantidad +
                "')";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(string identificador, string marca, string modelo, string tipo, int precio,
            int cantidad)
        {
            var sql =
                "UPDATE vehiculo SET marca = '" + marca + "', modelo = '" + modelo + "', tipo = '" + tipo +
                "', precio= '" + precio + "', cantidad = '" + cantidad + "' WHERE identificador = '" + identificador +
                "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM vehiculo WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
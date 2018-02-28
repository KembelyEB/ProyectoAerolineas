using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    public class VehiculoDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(Vehiculo vehiculo)
        {
            var sql =
                "INSERT INTO vehiculo (identificador, marca, modelo, tipo, precio, cantidad) VALUES ('" +
                 vehiculo.Identificador + "', '" + vehiculo.Marca + "', '" + vehiculo.Modelo + "', '" + vehiculo.Tipo + "', '" + vehiculo.Precio + "', '" + vehiculo.Cantidad +
                "')";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(Vehiculo vehiculo)
        {
            var sql =
                "UPDATE vehiculo SET marca = '" + vehiculo.Marca + "', modelo = '" + vehiculo.Modelo + "', tipo = '" + vehiculo.Tipo +
                "', precio= '" + vehiculo.Precio + "', cantidad = '" + vehiculo.Cantidad + "' WHERE identificador = '" + vehiculo.Identificador +
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
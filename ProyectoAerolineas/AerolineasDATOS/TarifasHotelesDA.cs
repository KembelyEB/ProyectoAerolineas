﻿namespace AerolineasDATOS
{
    public class TarifasHotelesDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(string identificador, int precio)
        {
            var sql =
                "INSERT INTO tarifas_hoteles (identificador, precio) VALUES ('" + identificador + "', '" + precio +
                "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(string identificador, int precio)
        {
            var sql =
                "UPDATE tarifas_hoteles SET precio = '" + precio + "' WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM lugares WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
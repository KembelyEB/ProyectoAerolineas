﻿using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    public class HotelesDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(Hotel hotel)
        {
            var sql = "INSERT INTO hoteles (identificador, nombre, foto, pais, lugar, habitaciones) VALUES ('" +
                      hotel.Identificador + "', '" + hotel.Nombre + "', '" + hotel.Foto + "', '" + hotel.Pais + "', '" + hotel.Lugar + "', '" +
                      hotel.Habitacion + "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(Hotel hotel)
        {
            var sql = "UPDATE hoteles SET nombre = '" + hotel.Nombre + "', foto = '" + hotel.Foto + "', pais = '" + hotel.Pais +
                      "', lugar= '" +
                      hotel.Lugar + "', habitaciones = '" + hotel.Habitacion + "' WHERE identificador = '" + hotel.Identificador + "'";

            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(string identificador)
        {
            var sql = "DELETE FROM hoteles WHERE identificador = '" + identificador + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
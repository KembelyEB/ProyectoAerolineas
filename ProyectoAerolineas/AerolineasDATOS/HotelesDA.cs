using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasDATOS
{
    public class HotelesDA
    {

        Conexion ClsConexion = new Conexion();
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;



        public void InsertarDatos(string identificador, string nombre, Byte foto, string pais, string lugar, int habitaciones)
        {

            ClsConexion.ConexionDT();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO hoteles (identificador, nombre, foto, pais, lugar, habitaciones) VALUES ('" + identificador + "', '" + nombre + "', '" + foto + "', '" + pais + "', '" + lugar + "', '" + habitaciones+ "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarDatos(string identificador, string nombre, Byte foto, string pais, string lugar, int habitaciones)
        {
            ClsConexion.ConexionDT();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE hoteles SET nombre = '" + nombre + "', foto = '" + foto + "', pais = '" + pais + "', lugar= '" + lugar + "', habitaciones = '" + habitaciones + "' WHERE identificador = '" + identificador + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarDatos(string identificador)
        {
            ClsConexion.ConexionDT();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM hoteles WHERE identificador = '" + identificador + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}

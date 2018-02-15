using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasDATOS
{
   public  class AeropuertosDA
    {

        Conexion ClsConexion = new Conexion();
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;



        public void InsertarDatos(string identificador, string nombre, string localidad, string IATA)
        {
            ClsConexion.ConexionDT();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO aeropuertos (identificador, nombre, localidad, iata ) VALUES ('" + identificador + "', '" + nombre + "', '" + localidad + "', '" + IATA + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarDatos(string identificador, string nombre , string localidad, string IATA)
        {
            ClsConexion.ConexionDT();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE aeropuertos SET nombre = '" + nombre + "', localidad = '" + localidad + "', iata = '" + IATA + "' WHERE identificador = '" + identificador + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarDatos(string identificador)
        {
            ClsConexion.ConexionDT();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM aeropuertos WHERE identificador = '" + identificador + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }


    }
}

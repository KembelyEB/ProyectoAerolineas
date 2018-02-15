using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasDATOS
{
    public class AerolineasDA
    {

        Conexion ClsConexion = new Conexion();
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;



        public void InsertarDatos(string identificador, string nombre)
        {
            ClsConexion.ConexionDT();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO aerolineas (identificador, nombre) VALUES ('" + identificador + "', '" + nombre + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarDatos(string identificador, string nombre)
        {
            ClsConexion.ConexionDT();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE aerolineas SET nombre = '" + nombre + "' WHERE identificador = '" + identificador + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarDatos(string identificador)
        {
            ClsConexion.ConexionDT();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM aerolineas WHERE identificador = '" + identificador + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}

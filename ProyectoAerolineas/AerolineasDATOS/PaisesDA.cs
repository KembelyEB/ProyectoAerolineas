using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasDATOS
{
   public class PaisesDA
    {

        Conexion ClsConexion = new Conexion();
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;



        public void InsertarDatos(string identificador, string nombre, Byte bandera)
        {
            ClsConexion.ConexionDT();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO paises (identificador, nombre, bandera) VALUES ('" + identificador + "', '" + nombre + "', '" + bandera + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarDatos(string identificador, string nombre, Byte bandera)
        {
            ClsConexion.ConexionDT();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE paises SET nombre = '" + nombre + "', bandera = '" + bandera + "' WHERE identificador = '" + identificador + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarDatos(string identificador)
        {
            ClsConexion.ConexionDT();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM paises WHERE identificador = '" + identificador + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}

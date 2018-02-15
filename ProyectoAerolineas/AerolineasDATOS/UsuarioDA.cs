using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasDATOS
{
    public class UsuarioDA
    {


        Conexion ClsConexion = new Conexion();
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;

      

        public void InsertarDatos(string cedula, string nombre, string contraseña )
            {
                ClsConexion.ConexionDT();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO estudiante (cedula, nombre, contraseña) VALUES ('" + cedula + "', '" + nombre + "', '" + contraseña  + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }

            public void ModificarDatos(string cedula, string nombre, string contraseña)
            {
            ClsConexion.ConexionDT();
            conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE estudiante SET nombre = '" + nombre + "', edad = '" + contraseña  + "' WHERE cedula = '" + cedula + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }

            public void EliminarDatos(int cedula)
            {
            ClsConexion.ConexionDT();
            conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM estudiante WHERE cedula = '" + cedula + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
}

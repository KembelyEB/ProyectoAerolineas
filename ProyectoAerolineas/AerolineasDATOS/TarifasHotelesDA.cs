using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasDATOS
{
   public class TarifasHotelesDA
    {
        Conexion ClsConexion = new Conexion();
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;



        public void InsertarDatos(string identificador, int precio)
        {
            ClsConexion.ConexionDT();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO tarifas_hoteles (identificador, precio) VALUES ('" + identificador + "', '" + precio + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarDatos(string identificador, int precio)
        {
            ClsConexion.ConexionDT();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE tarifas_hoteles SET precio = '" + precio + "' WHERE identificador = '" + identificador + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarDatos(string identificador)
        {
            ClsConexion.ConexionDT();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM lugares WHERE identificador = '" + identificador + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}

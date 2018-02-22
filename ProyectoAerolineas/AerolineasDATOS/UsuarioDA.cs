using AerolineasENTIDADES;

namespace AerolineasDATOS
{
    public class UsuarioDA
    {
        private readonly DataAccessBase _dataAccessBase = new DataAccessBase();

        public void InsertarDatos(Usuario usuario)
        {
            var sql =
                "INSERT INTO usuario (cedula, nombre, contraseña) VALUES ('" + usuario.Cedula + "', '" +
                usuario.Nombre + "', '" +
                usuario.Contrasena + "')";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void ModificarDatos(Usuario usuario)
        {
            var sql =
                "UPDATE usuario SET nombre = '" + usuario.Nombre + "', contraseña = '" + usuario.Contrasena + "' WHERE cedula = '" +
                usuario.Cedula + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }

        public void EliminarDatos(string cedula)
        {
            var sql = "DELETE FROM usuario WHERE cedula = '" + cedula + "'";
            _dataAccessBase.ExecuteNonQuery(sql);
        }
    }
}
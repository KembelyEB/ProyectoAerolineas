using AerolineasDATOS;
using AerolineasENTIDADES;
using AerolineasNEGOCIO.Validadores;
using FluentValidation;

namespace AerolineasNEGOCIO
{
    public class UsuarioBO
    {
        private readonly UsuarioDA _dataAccess = new UsuarioDA();

        public void RegistrarUsuario(Usuario usuario)
        {
            var validator = new UsuarioValidator();
            validator.ValidateAndThrow(usuario);

            _dataAccess.InsertarDatos(usuario);
        }

        public bool Loging(string nombreDeUsuario, string contrasena)
        {
            return true;
        }

        public void Modificar(Usuario usuario)
        {
            var validator = new UsuarioValidator();
            validator.ValidateAndThrow(usuario);

            _dataAccess.ModificarDatos(usuario);
        }
        public void Eliminar(Usuario cedula)
        {
            var validator = new UsuarioValidator();
            validator.ValidateAndThrow(cedula);

            _dataAccess.EliminarDatos(cedula);

        }
    }
}
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
    }
}
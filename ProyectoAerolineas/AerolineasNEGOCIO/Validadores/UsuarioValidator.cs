using AerolineasENTIDADES;
using FluentValidation;

namespace AerolineasNEGOCIO.Validadores
{
    /// <summary>
    /// this class creates the validation rules for users
    /// </summary>
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(usuario => usuario.Nombre).NotEmpty();
            RuleFor(usuario => usuario.Nombre).Length(1, 50);
            RuleFor(usuario => usuario.Cedula).NotEmpty();
            RuleFor(usuario => usuario.Cedula).Length(1, 50);
            RuleFor(usuario => usuario.Cedula).NotEmpty();
            RuleFor(usuario => usuario.Cedula).Length(1, 12);
        }
    }
}
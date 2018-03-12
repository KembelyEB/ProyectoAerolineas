using AerolineasENTIDADES;
using FluentValidation;


namespace AerolineasNEGOCIO.Validadores
{
    /// <summary>
    /// this class creates the validation rules for places
    /// </summary>
    public class LugarValidador : AbstractValidator<Lugar>
    {
        public LugarValidador()
        {
            RuleFor(Lugar => Lugar.Nombre).NotEmpty();
            RuleFor(Lugar => Lugar.Nombre).Length(1, 50);
           

        }
    }
}

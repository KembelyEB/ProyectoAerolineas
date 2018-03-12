using AerolineasENTIDADES;
using FluentValidation;


namespace AerolineasNEGOCIO.Validadores
{
    /// <summary>
    /// this class creates the validation rules for flight rates
    /// </summary>
    public class TarifaVueloValidador : AbstractValidator<TarifaVuelo>
    {
        public TarifaVueloValidador()
        {
            RuleFor(TarifaVuelo => TarifaVuelo.Ruta).NotEmpty();
            RuleFor(TarifaVuelo => TarifaVuelo.Ruta).Length(1, 50);
            RuleFor(TarifaVuelo => TarifaVuelo.Precio).NotEmpty();
            RuleFor(TarifaVuelo => TarifaVuelo.Precio).Length(1, 50);

        }
    }
}

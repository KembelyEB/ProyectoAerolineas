using AerolineasENTIDADES;
using FluentValidation;


namespace AerolineasNEGOCIO.Validadores
{
    /// <summary>
    /// this class creates the validation rules for hotel rates
    /// </summary>
    class TarifaHotelValidador : AbstractValidator <TarifaHotel>
    {
        public TarifaHotelValidador()
        {
            RuleFor(TarifaHotel => TarifaHotel.Precio).NotEmpty();
            RuleFor(TarifaHotel => TarifaHotel.Precio).Length(1, 50);
           


        }
    }
}

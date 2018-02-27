using AerolineasENTIDADES;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasNEGOCIO.Validadores
{
    class TarifaHotelValidador : AbstractValidator <TarifaHotel>
    {
        public TarifaHotelValidador()
        {
            RuleFor(TarifaHotel => TarifaHotel.Precio).NotEmpty();
            RuleFor(TarifaHotel => TarifaHotel.Precio).Length(1, 50);
           


        }
    }
}

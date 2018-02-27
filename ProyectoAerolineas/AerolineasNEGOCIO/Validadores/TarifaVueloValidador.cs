using AerolineasENTIDADES;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasNEGOCIO.Validadores
{
   public  class TarifaVueloValidador : AbstractValidator<TarifaVuelo>
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

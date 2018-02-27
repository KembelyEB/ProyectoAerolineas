using AerolineasENTIDADES;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasNEGOCIO.Validadores
{
    class VueloValidador : AbstractValidator<Vuelo>
    {
        public VueloValidador()
        {
            RuleFor(Vuelo => Vuelo.Ruta).NotEmpty();
            RuleFor(Vuelo => Vuelo.Ruta).Length(1, 50);
            RuleFor(Vuelo => Vuelo.Precio).NotEmpty();
            RuleFor(Vuelo => Vuelo.Precio).Length(1, 50);


        }

    }
}

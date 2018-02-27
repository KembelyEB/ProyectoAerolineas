using AerolineasENTIDADES;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasNEGOCIO.Validadores
{
    class RutaValidador : AbstractValidator<Ruta>
    {
        public RutaValidador()
        {
            RuleFor(Ruta => Ruta.Pais_Origen).NotEmpty();
            RuleFor(Ruta => Ruta.Pais_Origen).Length(1, 50);
            RuleFor(Ruta => Ruta.Pais_Destino).NotEmpty();
            RuleFor(Ruta => Ruta.Pais_Destino).Length(1, 50);
            RuleFor(Ruta => Ruta.Duracion).NotEmpty();
            RuleFor(Ruta => Ruta.Duracion).Length(1, 50);


        }
    }
}

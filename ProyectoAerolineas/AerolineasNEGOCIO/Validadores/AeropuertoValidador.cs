using AerolineasENTIDADES;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasNEGOCIO.Validadores
{
    class AeropuertoValidador : AbstractValidator<Aeropuerto>
    {
        public AeropuertoValidador()
        {
            RuleFor(Aeropuerto => Aeropuerto.Nombre).NotEmpty();
            RuleFor(Aeropuerto => Aeropuerto.Nombre).Length(1, 50);
            RuleFor(Aeropuerto => Aeropuerto.Localidad).NotEmpty();
            RuleFor(Aeropuerto => Aeropuerto.Iata).NotEmpty();
            RuleFor(Aeropuerto => Aeropuerto.Iata).Length(1, 50);

        }
    }
}

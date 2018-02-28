using AerolineasENTIDADES;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasNEGOCIO.Validadores
{
    class VehiculoValidador : AbstractValidator<Vehiculo>
    {
        public VehiculoValidador()
        {
            RuleFor(Vehiculo => Vehiculo.Marca).NotEmpty();
            RuleFor(Vehiculo => Vehiculo.Marca).Length(1, 50);
            RuleFor(Vehiculo => Vehiculo.Modelo).NotEmpty();
            RuleFor(Vehiculo => Vehiculo.Modelo).Length(1, 50);
            RuleFor(Vehiculo => Vehiculo.Tipo).NotEmpty();
            RuleFor(Vehiculo => Vehiculo.Tipo).Length(1, 50);
            RuleFor(Vehiculo => Vehiculo.Precio).NotEmpty();
            RuleFor(Vehiculo => Vehiculo.Precio).Length(1, 50);
            RuleFor(Vehiculo => Vehiculo.Cantidad).NotEmpty();
            RuleFor(Vehiculo => Vehiculo.Cantidad).Length(1, 50);
        }
    }
    }

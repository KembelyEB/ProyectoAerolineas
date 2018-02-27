using AerolineasENTIDADES;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasNEGOCIO.Validadores
{
    public class HotelValidador : AbstractValidator<Hotel>
    {
        public HotelValidador()
        {
            RuleFor(Hotel => Hotel.Nombre).NotEmpty();
            RuleFor(Hotel => Hotel.Nombre).Length(1, 50);
            RuleFor(Hotel => Hotel.Pais).NotEmpty();
            RuleFor(Hotel => Hotel.Pais).Length(1, 50);
            RuleFor(Hotel => Hotel.Lugar).NotEmpty();
            RuleFor(Hotel => Hotel.Lugar).Length(1, 50);
            RuleFor(Hotel => Hotel.Habitacion).NotEmpty();
            RuleFor(Hotel => Hotel.Habitacion).Length(1, 50);
            RuleFor(Hotel => Hotel.Foto).NotEmpty();
            


        }
    }
}

using AerolineasENTIDADES;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasNEGOCIO.Validadores
{
   public class LugarValidador : AbstractValidator<Lugar>
    {
        public LugarValidador()
        {
            RuleFor(Lugar => Lugar.Nombre).NotEmpty();
            RuleFor(Lugar => Lugar.Nombre).Length(1, 50);
           

        }
    }
}

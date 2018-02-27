using AerolineasENTIDADES;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasNEGOCIO.Validadores
{
   public  class PaisValidador : AbstractValidator<Pais>
    {
        public PaisValidador()
        {
            RuleFor(Pais => Pais.Nombre).NotEmpty();
            RuleFor(Pais => Pais.Nombre).Length(1, 50);
            RuleFor(Pais => Pais.Bandera).NotEmpty();
          
        }
    }
}

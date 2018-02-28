using AerolineasDATOS;
using AerolineasENTIDADES;
using AerolineasNEGOCIO.Validadores;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineasNEGOCIO
{
   public  class RutaBO
    {
        private readonly RutasDA _dataAccess = new RutasDA();

        public void RegistrarRuta(Ruta ruta)
        {
            var validator = new RutaValidador();
            validator.ValidateAndThrow(ruta);

            _dataAccess.InsertarDatos(ruta);
        }



    }
}

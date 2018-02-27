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
   public  class PaisesBO
    {

        private readonly PaisesDA _dataAccess = new PaisesDA();

        public void RegistrarPais(Pais pais)
        {
            var validator = new PaisValidador();
            validator.ValidateAndThrow(pais);

            _dataAccess.InsertarDatos(pais);
        }



    }
}

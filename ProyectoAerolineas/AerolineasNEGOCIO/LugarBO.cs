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
   public  class LugarBO
    {
        private readonly LugaresDA _dataAccess = new LugaresDA();

        public void RegistrarLugar(Lugar lugar)
        {
            var validator = new LugarValidador();
            validator.ValidateAndThrow(lugar);

            _dataAccess.InsertarDatos(lugar);
        }
    }
}

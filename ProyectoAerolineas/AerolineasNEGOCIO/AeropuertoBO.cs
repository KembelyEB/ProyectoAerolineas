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
    public class AeropuertoBO
    {

        private readonly AeropuertosDA _dataAccess = new AeropuertosDA();

        public void RegistrarAeropuerto(Aeropuerto aeropuerto)
        {
            var validator = new AeropuertoValidador();
            validator.ValidateAndThrow(aeropuerto);

            _dataAccess.InsertarDatos(aeropuerto);
        }
    }


}

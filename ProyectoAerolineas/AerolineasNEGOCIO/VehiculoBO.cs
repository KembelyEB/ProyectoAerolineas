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
    public class VehiculoBO
    {
        private readonly VehiculoDA _dataAccess = new VehiculoDA();

        public void RegistrarVehiculo(Vehiculo vehiculo)
        {
            var validator = new VehiculoValidador();
            validator.ValidateAndThrow(vehiculo);

            _dataAccess.InsertarDatos(vehiculo);
        }

    }
}

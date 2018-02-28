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
    public class TarifaVueloBO
    {
        private readonly TarifaVueloDA _dataAccess = new TarifaVueloDA();

        public void RegistrarLugar(TarifaVuelo tarifaVuelo)
        {
            var validator = new TarifaVueloValidador();
            validator.ValidateAndThrow(tarifaVuelo);

            _dataAccess.InsertarDatos(tarifaVuelo);
        }





    }
}

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
   public class TarifaHotelBO
    {
        private readonly TarifasHotelesDA _dataAccess = new TarifasHotelesDA();

        public void RegistrarTarifaHotel(TarifaHotel tarifaHotel)
        {
            var validator = new TarifaHotelValidador();
            validator.ValidateAndThrow(tarifaHotel);

            _dataAccess.InsertarDatos(tarifaHotel);
        }

        public void Modificar(TarifaHotel tHotel)
        {
            var validator = new TarifaHotelValidador();
            validator.ValidateAndThrow(tHotel);

            _dataAccess.ModificarDatos(tHotel);
        }
        public void Eliminar(string id)
        {

            _dataAccess.EliminarDatos(id);

        }

    }
}

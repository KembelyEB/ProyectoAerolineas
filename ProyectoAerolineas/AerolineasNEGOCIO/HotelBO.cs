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
   public class HotelBO
    {

        private readonly HotelesDA _dataAccess = new HotelesDA();

        public void RegistrarHotel(Hotel hotel)
        {
            var validator = new HotelValidador();
            validator.ValidateAndThrow(hotel);

            _dataAccess.InsertarDatos(hotel);
        }
        public void Modificar(Hotel hotel)
        {
            var validator = new HotelValidador();
            validator.ValidateAndThrow(hotel);

            _dataAccess.ModificarDatos(hotel);
        }
        public void Eliminaro(string id)
        {

            _dataAccess.EliminarDatos(id);

        }

    }
}

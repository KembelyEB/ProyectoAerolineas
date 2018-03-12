using AerolineasDATOS;
using AerolineasENTIDADES;
using AerolineasNEGOCIO.Validadores;
using FluentValidation;


namespace AerolineasNEGOCIO
{
    /// <summary>
    /// this class is responsible for validating and transferring objects
    /// between the data access layers and the user interface about hotels
    /// </summary>
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
        public void Eliminar(string id)
        {

            _dataAccess.EliminarDatos(id);

        }

    }
}

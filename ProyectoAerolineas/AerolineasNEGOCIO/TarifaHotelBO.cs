using AerolineasDATOS;
using AerolineasENTIDADES;
using AerolineasNEGOCIO.Validadores;
using FluentValidation;


namespace AerolineasNEGOCIO
{
    /// <summary>
    /// this class is responsible for validating and transferring objects
    /// between the data access layers and the user interface about hotel rates
    /// </summary>
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

using AerolineasDATOS;
using AerolineasENTIDADES;
using AerolineasNEGOCIO.Validadores;
using FluentValidation;

namespace AerolineasNEGOCIO
{
    /// <summary>
    /// this class is responsible for validating and transferring objects
    /// between the data access layers and the user interface about airports
    /// </summary>
    public class AeropuertoBO
    {

        private readonly AeropuertosDA _dataAccess = new AeropuertosDA();

        public void RegistrarAeropuerto(Aeropuerto aeropuerto)
        {
            var validator = new AeropuertoValidador();
            validator.ValidateAndThrow(aeropuerto);

            _dataAccess.InsertarDatos(aeropuerto);
        }

        public void Modificar(Aeropuerto aeropuerto)
        {
            var validator = new AeropuertoValidador();
            validator.ValidateAndThrow(aeropuerto);

            _dataAccess.ModificarDatos(aeropuerto);
        }
        public void Eliminaro(string id)
        {

            _dataAccess.EliminarDatos(id);

        }
    }


}

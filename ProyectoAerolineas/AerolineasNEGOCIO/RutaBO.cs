using AerolineasDATOS;
using AerolineasENTIDADES;
using AerolineasNEGOCIO.Validadores;
using FluentValidation;

namespace AerolineasNEGOCIO
{
    /// <summary>
    /// this class is responsible for validating and transferring objects
    /// between the data access layers and the user interface about routes
    /// </summary>
    public class RutaBO
    {
        private readonly RutasDA _dataAccess = new RutasDA();

        public void RegistrarRuta(Ruta ruta)
        {
            var validator = new RutaValidador();
            validator.ValidateAndThrow(ruta);

            _dataAccess.InsertarDatos(ruta);
        }

        public void Modificar(Ruta ruta)
        {
            var validator = new RutaValidador();
            validator.ValidateAndThrow(ruta);

            _dataAccess.ModificarDatos(ruta);
        }
        public void Eliminaro(string id)
        {

            _dataAccess.EliminarDatos(id);

        }

    }
}

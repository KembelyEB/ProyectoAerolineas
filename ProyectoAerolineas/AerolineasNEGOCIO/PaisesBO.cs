using AerolineasDATOS;
using AerolineasENTIDADES;
using AerolineasNEGOCIO.Validadores;
using FluentValidation;

namespace AerolineasNEGOCIO
{
    /// <summary>
    /// this class is responsible for validating and transferring objects
    /// between the data access layers and the user interface about countries
    /// </summary>
    public class PaisesBO
    {

        private readonly PaisesDA _dataAccess = new PaisesDA();

        public void RegistrarPais(Pais pais)
        {
            var validator = new PaisValidador();
            validator.ValidateAndThrow(pais);

            _dataAccess.InsertarDatos(pais);
        }

        public void Modificar(Pais pais)
        {
            var validator = new PaisValidador();
            validator.ValidateAndThrow(pais);

            _dataAccess.ModificarDatos(pais);
        }
        public void Eliminaro(string id)
        {

            _dataAccess.EliminarDatos(id);

        }

    }
}

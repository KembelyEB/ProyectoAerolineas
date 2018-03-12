using AerolineasDATOS;
using AerolineasENTIDADES;
using AerolineasNEGOCIO.Validadores;
using FluentValidation;

namespace AerolineasNEGOCIO
{
    /// <summary>
    /// this class is responsible for validating and transferring objects
    /// between the data access layers and the user interface about places
    /// </summary>
    public class LugarBO
    {
        private readonly LugaresDA _dataAccess = new LugaresDA();

        public void RegistrarLugar(Lugar lugar)
        {
            var validator = new LugarValidador();
            validator.ValidateAndThrow(lugar);

            _dataAccess.InsertarDatos(lugar);
        }


        public void Modificar(Lugar lugar)
        {
            var validator = new LugarValidador();
            validator.ValidateAndThrow(lugar);

            _dataAccess.ModificarDatos(lugar);
        }
        public void Eliminaro(string id)
        {

            _dataAccess.EliminarDatos(id);

        }
    }
}

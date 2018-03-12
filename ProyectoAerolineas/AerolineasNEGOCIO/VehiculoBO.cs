using AerolineasDATOS;
using AerolineasENTIDADES;
using AerolineasNEGOCIO.Validadores;
using FluentValidation;


namespace AerolineasNEGOCIO
{
    /// <summary>
    /// this class is responsible for validating and transferring objects
    /// between the data access layers and the user interface about cars
    /// </summary>
    public class VehiculoBO
    {
        private readonly VehiculoDA _dataAccess = new VehiculoDA();

        public void RegistrarVehiculo(Vehiculo vehiculo)
        {
            var validator = new VehiculoValidador();
            validator.ValidateAndThrow(vehiculo);

            _dataAccess.InsertarDatos(vehiculo);
        }
        public void ModificarVehiculo(Vehiculo vehiculo)
        {
            var validator = new VehiculoValidador();
            validator.ValidateAndThrow(vehiculo);

            _dataAccess.ModificarDatos(vehiculo);
        }
        public void EliminarVehiculo(string id)
        {
            _dataAccess.EliminarDatos(id);

        }
    }
}

using AerolineasDATOS;
using AerolineasENTIDADES;
using AerolineasNEGOCIO.Validadores;
using FluentValidation;


namespace AerolineasNEGOCIO
{
    /// <summary>
    /// this class is responsible for validating and transferring objects
    /// between the data access layers and the user interface about flight rates
    /// </summary>
    public class TarifaVueloBO
    {
        private readonly TarifaVueloDA _dataAccess = new TarifaVueloDA();

        public void RegistrarLugar(TarifaVuelo tarifaVuelo)
        {
            var validator = new TarifaVueloValidador();
            validator.ValidateAndThrow(tarifaVuelo);

            _dataAccess.InsertarDatos(tarifaVuelo);
        }

        public void Modificar(TarifaVuelo tVuelo)
        {
            var validator = new TarifaVueloValidador();
            validator.ValidateAndThrow(tVuelo);

            _dataAccess.ModificarDatos(tVuelo);
        }
        public void Eliminaro(string id)
        {
       
            _dataAccess.EliminarDatos(id);

        }




    }
}

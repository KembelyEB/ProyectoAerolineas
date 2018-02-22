using AerolineasDATOS;
using AerolineasENTIDADES;

namespace AerolineasNEGOCIO
{
    internal class AerolineaBO
    {
        private readonly AerolineasDA _dataAccess = new AerolineasDA();

        public void InsertarDatos(Aerolinea aerolinea)
        {
            _dataAccess.InsertarDatos(aerolinea);
        }
    }
}
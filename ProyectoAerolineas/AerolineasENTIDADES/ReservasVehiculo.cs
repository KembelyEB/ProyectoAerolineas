using System;
using System.Collections.Generic;
using System.Text;

namespace AerolineasENTIDADES
{
   public  class ReservasVehiculo
    {
        public int id { get; set; }
        public string tipoAuto { get; set; }
        public DateTime Retira { get; set; }
        public DateTime Entrega { get; set; }
        public int id_Vehiculos { get; set; }

    }
}

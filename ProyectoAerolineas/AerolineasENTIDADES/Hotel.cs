namespace AerolineasENTIDADES
{
    /// <summary>
    /// this class creates the hotel object
    /// </summary>
    public class Hotel
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public string Pais { get; set; }
        public string Lugar { get; set; }
        public string Habitacion { get; set; }
        public string fk_TarifaVuelo { get; set; }

    }
}
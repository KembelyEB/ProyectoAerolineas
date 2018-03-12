using AerolineasENTIDADES;
using FluentValidation;


namespace AerolineasNEGOCIO.Validadores
{
    /// <summary>
    /// this class creates the validation rules for routes
    /// </summary>
    class RutaValidador : AbstractValidator<Ruta>
    {
        public RutaValidador()
        {
            RuleFor(Ruta => Ruta.Pais_Origen).NotEmpty();
            RuleFor(Ruta => Ruta.Pais_Origen).Length(1, 50);
            RuleFor(Ruta => Ruta.Pais_Destino).NotEmpty();
            RuleFor(Ruta => Ruta.Pais_Destino).Length(1, 50);
            RuleFor(Ruta => Ruta.Duracion).NotEmpty();
            RuleFor(Ruta => Ruta.Duracion).Length(1, 50);


        }
    }
}

using AerolineasENTIDADES;
using FluentValidation;


namespace AerolineasNEGOCIO.Validadores
{
    /// <summary>
    /// this class creates the validation rules for countries
    /// </summary>
    public class PaisValidador : AbstractValidator<Pais>
    {
        public PaisValidador()
        {
            RuleFor(Pais => Pais.Nombre).NotEmpty();
            RuleFor(Pais => Pais.Nombre).Length(1, 50);
            RuleFor(Pais => Pais.Bandera).NotEmpty();
          
        }
    }
}

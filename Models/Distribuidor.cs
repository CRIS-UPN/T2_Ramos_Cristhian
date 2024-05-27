using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace T2_Ramos_Cristhian.Models
{
    public class Distribuidor
    {
        [Key]

        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre del Distribuidor es obligatorio")]
        public string NombreDistribuidor { get; set; }
        [Required(ErrorMessage = "La Razon Social es obligatoria")]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El Anio de inicio de Operacion es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El Anio de inicio de Operacion debe ser entre 1900 y 3000")]
        public string AnioInicioOperacion { get; set; }
        [Required(ErrorMessage = "El Contacto es obligatorio")]
        public string Contacto  { get; set; }

    }
}

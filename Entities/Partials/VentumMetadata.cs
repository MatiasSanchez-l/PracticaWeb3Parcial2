using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Partials
{
    class VentumMetadata
    {
        [Required(ErrorMessage = "Se requiere completar este campo")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Debe seleccionar un cliente")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Se requiere completar este campo")]
        [Range(2, 299, ErrorMessage = "La cantidad vendida debe ser mayor a 1 y menor a 300.")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Solo puede ingresar valores numericos")]
        public int CantidadVendida { get; set; }

        [Required(ErrorMessage = "Se requiere completar este campo")]
        [Range(10, 999, ErrorMessage = "El precio unitario debe ser mayor a 9 y menor a 1000.")]
        public int PrecioUnitario { get; set; }
    }
}

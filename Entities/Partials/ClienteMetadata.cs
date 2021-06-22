using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Partials
{
    class ClienteMetadata
    {
        [Required(ErrorMessage = "Se requiere completar este campo")]
        [StringLength(50, ErrorMessage = "no puede superar los 50 caracteres.")]
        public string Nombre { get; set; }
    }
}

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
        [Required]
        public string Nombre { get; set; }
    }
}

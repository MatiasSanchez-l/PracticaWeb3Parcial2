using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Ventum
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int CantidadVendida { get; set; }
        public int PrecioUnitario { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
    }
}

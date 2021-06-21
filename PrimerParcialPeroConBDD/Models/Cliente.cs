using System;
using System.Collections.Generic;

#nullable disable

namespace PrimerParcialPeroConBDD.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Venta = new HashSet<Ventum>();
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Ventum> Venta { get; set; }
    }
}

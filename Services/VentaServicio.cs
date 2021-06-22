using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class VentaServicio : IVentaServicio
    {
        private practicaPrimerParcialConBDDContext _dBContext;
        public VentaServicio(practicaPrimerParcialConBDDContext dBContext)
        {
            _dBContext = dBContext;
        }

        public void Crear(Ventum Venta)
        {

            _dBContext.Venta.Add(Venta);
            _dBContext.SaveChanges();
        }

        public Ventum devolverVentaConTotal(Ventum Venta)
        {
            Ventum ventaConTotal = new Ventum();

            ventaConTotal.IdCliente = Venta.IdCliente;
            ventaConTotal.PrecioUnitario = Venta.PrecioUnitario;
            ventaConTotal.CantidadVendida = Venta.CantidadVendida;
            ventaConTotal.TotalVenta = Venta.CantidadVendida * Venta.PrecioUnitario;

            return ventaConTotal;
        }

        public void Modificar(Ventum Venta)
        {
            throw new NotImplementedException();
        }

        public Ventum obtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ventum> obtenerTodos()
        {
            return _dBContext.Venta
                .ToList();
        }
    }
}

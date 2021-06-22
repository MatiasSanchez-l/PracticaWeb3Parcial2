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
            Ventum ventaConTotal;
            if (Venta.IdVenta != 0)
            {
                ventaConTotal = obtenerPorId(Venta.IdVenta);
            }
            else
            {
                ventaConTotal = new Ventum();
            }
            

            ventaConTotal.IdCliente = Venta.IdCliente;
            ventaConTotal.PrecioUnitario = Venta.PrecioUnitario;
            ventaConTotal.CantidadVendida = Venta.CantidadVendida;
            ventaConTotal.TotalVenta = Venta.CantidadVendida * Venta.PrecioUnitario;

            return ventaConTotal;
        }

        public void Modificar(Ventum Venta)
        {
            Ventum objActual = obtenerPorId(Venta.IdVenta);
            objActual.IdCliente = Venta.IdCliente;
            objActual.IdClienteNavigation = Venta.IdClienteNavigation;
            objActual.PrecioUnitario = Venta.PrecioUnitario;
            objActual.CantidadVendida = Venta.CantidadVendida;
            objActual.TotalVenta = Venta.TotalVenta;

            _dBContext.SaveChanges();
        }

        public Ventum obtenerPorId(int id)
        {
            return _dBContext.Venta
                .FirstOrDefault(o => o.IdVenta == id);
        }

        public List<Ventum> obtenerTodos()
        {
            /* return _dBContext.Venta
                 .Include(o => o.IdClienteNavigation)
                 .ToList();*/
            var query = from venta in _dBContext.Venta
                        join cliente in _dBContext.Clientes on venta.IdCliente equals cliente.IdCliente
                        select new Ventum{ IdVenta=venta.IdVenta, CantidadVendida=venta.CantidadVendida, PrecioUnitario=venta.PrecioUnitario,
                            TotalVenta=venta.TotalVenta, IdClienteNavigation = cliente };
            
            List<Ventum> todasLasVentas = new List<Ventum>();
            foreach (var venta in query)
            {
                todasLasVentas.Add(venta);
            }
            return todasLasVentas;
        }
    }
}

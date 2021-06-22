using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IVentaServicio
    {
        void Crear(Ventum Venta);

        void Modificar(Ventum Venta);

        Ventum obtenerPorId(int id);

        Ventum devolverVentaConTotal(Ventum Venta);

        List<Ventum> obtenerTodos();

        List<Ventum> obtenerTodosPorIdCliente(int id);
        void Borrar(Ventum Venta);
    }
}

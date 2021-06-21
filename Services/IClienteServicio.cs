using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IClienteServicio
    {
        void Crear(Cliente Cliente);

        void Modificar(Cliente Cliente);
        Cliente obtenerPorId(int id);
        List<Cliente> obtenerTodos();
    }
}

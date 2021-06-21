using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ClienteServicio : IClienteServicio
    {
        private practicaPrimerParcialConBDDContext _dBContext;
        public ClienteServicio(practicaPrimerParcialConBDDContext dBContext)
        {
            _dBContext = dBContext;
        }

        public void Crear(Cliente Cliente)
        {
            _dBContext.Clientes.Add(Cliente);
            _dBContext.SaveChanges();
        }

        public void Modificar(Cliente Cliente)
        {
            Cliente objActual = obtenerPorId(Cliente.IdCliente);
            objActual.Nombre = Cliente.Nombre;
            _dBContext.SaveChanges();
        }

        public Cliente obtenerPorId(int id)
        {
            return _dBContext.Clientes
                .FirstOrDefault(o => o.IdCliente == id);
        }

        public List<Cliente> obtenerTodos()
        {
            return _dBContext.Clientes.ToList();
        }
    }
}

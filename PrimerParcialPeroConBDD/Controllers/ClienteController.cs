using Entities.Models;
using Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialPeroConBDD.Controllers
{
    public class ClienteController : Controller
    {

        private IClienteServicio _clienteServicio;

        public ClienteController()
        {
            practicaPrimerParcialConBDDContext dBContext = new practicaPrimerParcialConBDDContext();
            _clienteServicio = new ClienteServicio(dBContext);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return View(cliente);
            }
            _clienteServicio.Crear(cliente);
            return Redirect("/Cliente/Listar");
        }

        [HttpGet]
        public IActionResult Listar()
        {
            List<Cliente> clientes = _clienteServicio.obtenerTodos();
            return View(clientes);
        }

        [HttpGet]
        public IActionResult Modificar(int idCliente)
        {
            Cliente cliente = _clienteServicio.obtenerPorId(idCliente);
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Modificar(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return View(cliente);
            }
            _clienteServicio.Modificar(cliente);
            return Redirect("/Cliente/Listar");
        }
    }
}

using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialPeroConBDD.Controllers
{
    public class VentaController : Controller
    {
        private IVentaServicio _ventaServicio;
        private IClienteServicio _clienteServicio;
        public VentaController()
        {
            practicaPrimerParcialConBDDContext dBContext = new practicaPrimerParcialConBDDContext();
            _ventaServicio = new VentaServicio(dBContext);
            _clienteServicio = new ClienteServicio(dBContext);
        }



        [HttpGet]
        public IActionResult Crear()
        {
            ViewBag.TodosClientes = _clienteServicio.obtenerTodos();
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Ventum venta)
        {
            if (!ModelState.IsValid)
            {
                return View(venta);
            }
            _ventaServicio.Crear(_ventaServicio.devolverVentaConTotal(venta));
            return Redirect("/Venta/Listar");
        }

        [HttpGet]
        public IActionResult Listar()
        {
            List<Ventum> ventas = _ventaServicio.obtenerTodos();
            return View(ventas);
        }
    }
}

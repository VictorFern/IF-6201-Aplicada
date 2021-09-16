using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using IF6201_TomeYLleve.Models;

namespace IF6201_TomeYLleve.Controllers
{
    public class AdminController : Controller
    {
        public IConfiguration Configuration { get; }

        public AdminController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult registrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult registrar(ProductoModel productoModel)
        {
            return View();
        }

        public IActionResult buscar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult buscar(ProductoModel productoModel)
        {
            return View();
        }

        public IActionResult eliminar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult eliminar(ProductoModel productoModel)
        {
            return View();
        }

        public IActionResult actualizar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult actualizar(ProductoModel productoModel)
        {
            return View();
        }
    }
}

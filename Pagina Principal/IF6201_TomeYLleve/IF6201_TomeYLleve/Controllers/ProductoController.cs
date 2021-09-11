using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using IF6201_TomeYLleve.Models;

namespace IF6201_TomeYLleve.Controllers
{
    public class ProductoController : Controller
    {
        public IConfiguration Configuration { get; }

        public ProductoController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Index()
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

        public IActionResult pago()
        {
            return View();
        }
        [HttpPost]
        public IActionResult pago(ProductoModel productoModel)
        {
            return View();
        }

        public IActionResult carrito()
        {
            return View();
        }

        public IActionResult vercarrito()
        {
            return View();
        }
    }
}

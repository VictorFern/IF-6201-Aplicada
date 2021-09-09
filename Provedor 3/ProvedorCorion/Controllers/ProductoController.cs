using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProvedorCorion.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProvedorCorion.Controllers
{
    public class ProductoController : Controller
    {
        public IConfiguration Configuration { get; set; }
        public ProductoController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrar(ProductoModel productoModel)
        {
            if (ModelState.IsValid)
            {
                string conexionString = Configuration["ConnectionStrings:DB_Connection_Turrialba"];
                var connection = new SqlConnection(conexionString);

                string sqlQuery = $"exec sp_insert_product @param_NOMBRE = '{productoModel.Nombre}', " +
                    $"@param_MARCA = '{productoModel.Marca}', " +
                    $"@param_PRECIO = '{productoModel.Precio}', " +
                    $"@param_DIMENSIONES = '{productoModel.Dimensiones}', @param_DESCRIPCION = '{productoModel.Descripcion}'";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();
                };
            }
            return View("Index");
        }
    }
}

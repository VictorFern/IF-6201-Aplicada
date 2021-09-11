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
        public IActionResult Listar()
        {
            List<ProductoModel> productos = new List<ProductoModel>();
            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DB_Connection_Turrialba"];
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = $"exec sp_get_allproducts";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        SqlDataReader productosReader = command.ExecuteReader();
                        while (productosReader.Read())
                        {
                            ProductoModel temp = new ProductoModel();
                            temp.Id = Int32.Parse(productosReader["ID"].ToString());
                            temp.Nombre = productosReader["NOMBRE"].ToString();
                            temp.Marca = productosReader["MARCA"].ToString();
                            temp.Precio = Int32.Parse(productosReader["PRECIO"].ToString());
                            temp.Dimensiones = productosReader["DIMENSIONES"].ToString();
                            temp.Descripcion = productosReader["DESCRIPCION"].ToString();
                            productos.Add(temp);
                        } // while
                        connection.Close();
                    }
                }
            }
            ViewBag.Productos = productos;
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProvedorCorion.Models;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;

namespace ProvedorCorion.Controllers
{
    public class ProductoController : Controller
    {
        public IConfiguration Configuration { get; set; }
        private readonly IHostingEnvironment _webhost;
        public ProductoController(IConfiguration configuration, IHostingEnvironment webhost)
        {
            Configuration = configuration;
            _webhost = webhost;
        }
        public IActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrar(ProductoModel productoModel)
        {
            var newFileName = string.Empty;
            var fileName = "";
            Console.WriteLine("antes del if de !=null");
            if (HttpContext.Request.Form.Files != null)
            {
                Console.WriteLine("entro en el if");
                Console.WriteLine(productoModel.Image);
                fileName = string.Empty;
                string PathDB = string.Empty;

                var files = HttpContext.Request.Form.Files;
                Console.WriteLine(HttpContext.Request.Form.Files.Count);

                foreach (var file in files)
                {
                    Console.WriteLine("entro al foreach");
                    if (file.Length > 0)
                    {
                        Console.WriteLine("entro al if de length");
                        //Getting FileName
                        fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                        //Assigning Unique Filename (Guid)
                        var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                        //Getting file Extension
                        var FileExtension = Path.GetExtension(fileName);

                        // concating  FileName + FileExtension
                        newFileName = myUniqueFileName + FileExtension;

                        // Combines two strings into a path.
                        fileName = Path.Combine(_webhost.WebRootPath, "img") + $@"\{newFileName}";

                        // if you want to store path of folder in database
                        PathDB = "img/" + newFileName;

                        using (FileStream fs = System.IO.File.Create(fileName))
                        {
                            Console.WriteLine("entro al using");
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
            }
            if (ModelState.IsValid)
            {
                Console.WriteLine("lo que se guardara en la bd: ");
                Console.WriteLine(newFileName);
                string conexionString = Configuration["ConnectionStrings:DB_Connection_Turrialba"];
                var connection = new SqlConnection(conexionString);

                string sqlQuery = $"exec sp_insert_product @param_NOMBRE = '{productoModel.Nombre}', " +
                    $"@param_MARCA = '{productoModel.Marca}', " +
                    $"@param_PRECIO = '{productoModel.Precio}', " +
                    $"@param_DIMENSIONES = '{productoModel.Dimensiones}', " +
                    $"@param_DESCRIPCION = '{productoModel.Descripcion}', @param_PIMAGE = '{newFileName}'";
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
                            temp.Image = productosReader["PIMAGE"].ToString();
                            productos.Add(temp);
                        } // while
                        connection.Close();
                    }
                }
            }
            ViewBag.Productos = productos;
            return View();
        }
        [HttpPost]
        public IActionResult EliminarProducto(ProductoModel productoModel)
        {
            string conexionString = Configuration["ConnectionStrings:DB_Connection_Turrialba"];
            var connection = new SqlConnection(conexionString);

            string sqlQuery = $"exec sp_delete_product @param_ID = '{productoModel.Id}'";
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteReader();
                connection.Close();
            };
            return View("Index");
        }
        [HttpPost]
        public String ActualizarProducto(ProductoModel productoModel)
        {
            string conexionString = Configuration["ConnectionStrings:DB_Connection_Turrialba"];
            var connection = new SqlConnection(conexionString);

            string sqlQuery = $"exec sp_get_product @param_ID = '{productoModel.Id}'";
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                command.CommandType = CommandType.Text;
                connection.Open();
                SqlDataReader vacunaReader = command.ExecuteReader();
                ProductoModel temp = new ProductoModel();
                if (vacunaReader.Read())
                {
                    temp.Id = Int32.Parse(vacunaReader["ID"].ToString());
                    temp.Nombre = vacunaReader["NOMBRE"].ToString();
                    temp.Marca = vacunaReader["MARCA"].ToString();
                    temp.Precio = Int32.Parse(vacunaReader["PRECIO"].ToString());
                    temp.Dimensiones = vacunaReader["DIMENSIONES"].ToString();
                    temp.Descripcion = vacunaReader["DESCRIPCION"].ToString();
                }
                connection.Close();
                return "<div class='row'>"
                    + "<div class='col-md-3' id='divid'>"
            + "<label for= 'inputEmail4' class='form-label'>ID</label>"
            + "<input asp-for='Id' type= 'text' class='form-control text-center' value='" + temp.Id + "' readonly='readonly' required id = 'Id' name='Id' placeholder='ID del producto'>"
            + "</div>"
            + "<div class='col-md-3'>"
                + "<label for='inputEmail4' class='form-label'>Nombre</label>"
                + "<input asp-for='Nombre' type= 'text' class='form-control text-center' value='" + temp.Nombre + "' required id = 'Nombre' name='Nombre' placeholder='Nombre del producto'>"
            + "</div>"
            + "<div class='col-md-3'>"
                + "<label for='inputEmail4' class='form-label'>Marca</label>"
                + "<input asp-for='Marca' type='text' class='form-control text-center' value='" + temp.Marca + "' required id = 'Marca' name='Marca' placeholder='Marca del producto'>"
            + "</div>"
            + "<div class='col-md-3'>"
                + "<label for='inputEmail4' class='form-label'>Precio</label>"
                + "<input asp-for='Precio' type='text' class='form-control text-center' value='" + temp.Precio + "' required id = 'Precio' name='Precio' placeholder='Precio del producto'>"
            + "</div>"
            + "</div>"
            + "<div class='row'>"
            + "<div class='col-md-6'>"
                + "<label for='inputEmail4' class='form-label'>Dimensiones</label>"
                + "<input asp-for='Dimensiones' type='text' class='form-control text-center' value='" + temp.Dimensiones + "' required id = 'Dimensiones' name='Dimensiones' placeholder='Dimensiones del producto'>"
            + "</div>"
            + "<div class='col-md-6'>"
                + "<label for='inputEmail4' class='form-label'>Descripcion</label>"
                + "<input asp-for='Descripcion' type='text' class='form-control text-center' value='" + temp.Descripcion + "' required id = 'Descripcion' name='Descripcion' placeholder='Precio del producto'>"
            + "</div>"
            + "</div>"
            + "<div class='col-12 w-auto mx-3 text-center my-3'>"
            + "<button type = 'submit' class='btn btn-primary text-center mt-3'>Actualizar</button>"
            + "</div>";
            };
        }
        [HttpPost]
        public IActionResult Update(ProductoModel productoModel)
        {
            if (ModelState.IsValid)
            {
                string conexionString = Configuration["ConnectionStrings:DB_Connection_Turrialba"];
                var connection = new SqlConnection(conexionString);

                string sqlQuery = $"exec sp_update_product @param_ID = '{productoModel.Id}', " +
                    $"@param_NOMBRE = '{productoModel.Nombre}', " +
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

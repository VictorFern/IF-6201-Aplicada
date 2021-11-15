using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using IF6201_TomeYLleve.Models;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace IF6201_TomeYLleve.Controllers
{
    public class AdminController : Controller
    {
        public IConfiguration Configuration { get; }
        private readonly IHostingEnvironment _webhost;
        public AdminController(IConfiguration configuration, IHostingEnvironment webhost)
        {
            Configuration = configuration;
            _webhost = webhost;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult registrar()
        {
	   List<CategoriaModel> categorias = new List<CategoriaModel>();
            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = $"sp_categorias";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        connection.Open();
                        SqlDataReader categoriaReader = command.ExecuteReader();
                        while (categoriaReader.Read())
                        {
                            CategoriaModel categoriaModel = new CategoriaModel();
                            categoriaModel.id = Int32.Parse(categoriaReader["ID"].ToString());
                            categoriaModel.categoria = categoriaReader["CATEGORIA"].ToString();
                            categorias.Add(categoriaModel);
                        }
                        connection.Close();
                    }
                }
            }
            ViewBag.Categoria = categorias;
            return View();
        }
        [HttpPost]
        public IActionResult registrar(ProductoModel productoModel)
        {

            var newFileName = string.Empty;
            var fileName = "";
            if (HttpContext.Request.Form.Files != null)
            {
                fileName = string.Empty;
                string PathDB = string.Empty;

                var files = HttpContext.Request.Form.Files;

                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
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
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
            }

            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                var connection = new SqlConnection(connectionString);
                string sqlQuery = $"sp_registrarProducto @param_NOMBREP ='{productoModel.nombre}',@param_DESCRIPCION ='{productoModel.descripcion}',@param_PRECIO ='{productoModel.precio}',@param_DIMENSION ='{productoModel.dimension}',@param_OTRASCARACTERISTICAS ='{productoModel.otrascaracteristicas}',@param_FOTO ='{newFileName}',@param_CANTIDAD ='{productoModel.cantidad}',@param_IDP ='{productoModel.proveedorModel.id}',@param_IDC ='{productoModel.categoriaModel.id}',@param_MARCA ='{productoModel.marca}'";
               
                using (SqlCommand command = new SqlCommand(sqlQuery,connection))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();
                }
                TempData["Success"] = "Se registró correctamente.";
                return RedirectToAction("registrar");
            }
            return RedirectToAction("registrar");
        }

        public IActionResult buscar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult buscar(ProductoModel productoModel)
        {
            List<object> lista = new List<object>();
            if (ModelState.IsValid)
            {
                string connectioString = Configuration["ConnectionStrings:DB_Connection"];
                using (SqlConnection connection = new SqlConnection(connectioString))
                {
                    string sqlQuery = $"sp_listaProducto @param_NOMBREP='{productoModel.nombre}'";
                    using (SqlCommand command = new SqlCommand(sqlQuery,connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        connection.Open();
                        SqlDataReader productoReader = command.ExecuteReader();
                        while (productoReader.Read())
                        {
                            CategoriaModel categoriaModel = new CategoriaModel();
                            categoriaModel.categoria = productoReader["CATEGORIA"].ToString();
                            ProveedorModel proveedorModel = new ProveedorModel();
                            proveedorModel.proveedor = productoReader["PROVEEDOR"].ToString();
                            ProductoModel productoTemp = new ProductoModel(productoReader["NOMBREP"].ToString()
                                                                           , productoReader["MARCA"].ToString()
                                                                           , productoReader["DESCRIPCION"].ToString()
                                                                           , Int32.Parse(productoReader["PRECIO"].ToString())
                                                                           , productoReader["DIMENSION"].ToString()
                                                                           , productoReader["OTRASCARACTERISTICAS"].ToString()
                                                                           , productoReader["FOTO"].ToString()
                                                                           , Int32.Parse(productoReader["CANTIDAD"].ToString())
                                                                           , categoriaModel
                                                                           , proveedorModel);
                            lista.Add(productoTemp);
                        }
                        connection.Close();
                    }
                }
            }
            ViewBag.Lista = lista;
            return View();
        }
        public IActionResult buscaEliminaActualiza()
        {
            return View();
        }
        [HttpPost]
        public IActionResult buscaEliminaActualiza(ProductoModel productoModel)
        {
            return View();
        }

        public IActionResult mostrarProducto()
        {
            return View();
        }
        [HttpPost]
        public IActionResult mostrarProducto(ProductoModel productoModel)
        {
            List<object> lista = new List<object>();
            if (ModelState.IsValid)
            {
                string connectioString = Configuration["ConnectionStrings:DB_Connection"];
                using (SqlConnection connection = new SqlConnection(connectioString))
                {
                    string sqlQuery = $"sp_listaProducto @param_NOMBREP='{productoModel.nombre}'";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        connection.Open();
                        SqlDataReader productoReader = command.ExecuteReader();
                        while (productoReader.Read())
                        {
                            CategoriaModel categoriaModel = new CategoriaModel();
                            categoriaModel.categoria = productoReader["CATEGORIA"].ToString();
                            ProveedorModel proveedorModel = new ProveedorModel();
                            proveedorModel.proveedor = productoReader["PROVEEDOR"].ToString();
                            ProductoModel productoTemp = new ProductoModel(Int32.Parse(productoReader["IDP"].ToString())
                                                                            , productoReader["NOMBREP"].ToString()
                                                                           , productoReader["MARCA"].ToString()
                                                                           , productoReader["DESCRIPCION"].ToString()
                                                                           , Int32.Parse(productoReader["PRECIO"].ToString())
                                                                           , productoReader["DIMENSION"].ToString()
                                                                           , productoReader["OTRASCARACTERISTICAS"].ToString()
                                                                           , productoReader["FOTO"].ToString()
                                                                           , Int32.Parse(productoReader["CANTIDAD"].ToString())
                                                                           , categoriaModel
                                                                           , proveedorModel);
                            lista.Add(productoTemp);
                        }
                        connection.Close();
                    }
                }
            }
            ViewBag.Lista = lista;
            return View();

        }



        public IActionResult eliminar(int id)
        {
            ProductoModel productoTemp = new ProductoModel();
            if (ModelState.IsValid)
            {
                string connectioString = Configuration["ConnectionStrings:DB_Connection"];
                using (SqlConnection connection = new SqlConnection(connectioString))
                {
                    string sqlQuery = $"sp_eliminarProductoID @param_ID='{id}'";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        connection.Open();
                        SqlDataReader productoReader = command.ExecuteReader();


                        connection.Close();
                    }
                }
            }

            return RedirectToAction("index");

        }

        [HttpPost]
        public IActionResult eliminar(ProductoModel productoModel)
        {

            return View();
        }

        public IActionResult actualizar(int id)
        {
            ProductoModel productoTemp = new ProductoModel();
            if (ModelState.IsValid)
            {
                string connectioString = Configuration["ConnectionStrings:DB_Connection"];
                using (SqlConnection connection = new SqlConnection(connectioString))
                {
                    string sqlQuery = $"sp_mostrarProductoID @param_ID='{id}'";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        connection.Open();
                        SqlDataReader productoReader = command.ExecuteReader();

                        while (productoReader.Read())
                        {

                            CategoriaModel categoriaModel = new CategoriaModel();
                            categoriaModel.categoria = productoReader["CATEGORIA"].ToString();
                            ProveedorModel proveedorModel = new ProveedorModel();
                            proveedorModel.proveedor = productoReader["PROVEEDOR"].ToString();
                            productoTemp = new ProductoModel(productoReader["NOMBREP"].ToString()
                                                                           , productoReader["MARCA"].ToString()
                                                                           , productoReader["DESCRIPCION"].ToString()
                                                                           , Int32.Parse(productoReader["PRECIO"].ToString())
                                                                           , productoReader["DIMENSION"].ToString()
                                                                           , productoReader["OTRASCARACTERISTICAS"].ToString()
                                                                           , productoReader["FOTO"].ToString()
                                                                           , Int32.Parse(productoReader["CANTIDAD"].ToString())
                                                                           , categoriaModel
                                                                           , proveedorModel);

                        }
                        connection.Close();
                    }
                }
            }

            return View(productoTemp);
        }
        [HttpPost]
        public IActionResult actualizar(ProductoModel productoModel)
        {
            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                var connection = new SqlConnection(connectionString);
                string sqlQuery = $"sp_actualizarProductoID @param_IDP ='{productoModel.id}', @param_NOMBREP ='{productoModel.nombre}',@param_DESCRIPCION ='{productoModel.descripcion}',@param_PRECIO ='{productoModel.precio}',@param_DIMENSION ='{productoModel.dimension}',@param_OTRASCARACTERISTICAS ='{productoModel.otrascaracteristicas}',@param_CANTIDAD ='{productoModel.cantidad}', @param_MARCA ='{productoModel.marca}'";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();
                }
                TempData["Success"] = "Se actualizo correctamente.";

            }

            return View();
        }
        public ActionResult cerrarSesion()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("iniciarSesion", "Usuario");
        }
        public ActionResult bloquear(int id)
        {
            ProductoModel productoTemp = new ProductoModel();
            if (ModelState.IsValid)
            {
                string connectioString = Configuration["ConnectionStrings:DB_Connection"];
                using (SqlConnection connection = new SqlConnection(connectioString))
                {
                    string sqlQuery = $"sp_BLOQUEAR @param_ID='{id}'";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        connection.Open();
                        SqlDataReader productoReader = command.ExecuteReader();


                        connection.Close();
                    }
                }
            }

            return RedirectToAction("buscaEliminaActualiza");
        }
    }


}

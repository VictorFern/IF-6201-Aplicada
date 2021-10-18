using IF6201_TomeYLleve.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace IF6201_TomeYLleve.Controllers
{
    public class ClienteController : Controller
    {
        public ClienteController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public IActionResult Index()
        {
            List<object> lista = new List<object>();
            if (ModelState.IsValid)
            {
                string connectioString = Configuration["ConnectionStrings:DB_Connection"];
                using (SqlConnection connection = new SqlConnection(connectioString))
                {
                    string sqlQuery = $"sp_mostrarProducto";
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

            ViewBag.Producto = lista;
            return View();
        }
        public IActionResult registrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult registrar(ClienteModel clienteModel)
        {
            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                var connection = new SqlConnection(connectionString);
                string sqlQuery = $"exec sp_registrarCliente @param_CEDULA='{clienteModel.cedula}',@param_NOMBRE='{clienteModel.nombre}',@param_APELLIDO='{clienteModel.apellido}',@param_ALIAS='{clienteModel.alias}',@param_CONTRASENNA='{clienteModel.contrasenna}'";
                using (SqlCommand command = new SqlCommand(sqlQuery,connection))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();
                }
                TempData["Success"] = "Se registró correctamente.";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult buscar(ProductoModel productoModel)
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

        public IActionResult producto(ProductoModel productoModel)
        {
            List<object> lista = new List<object>();
            if (ModelState.IsValid)
            {
                string connectioString = Configuration["ConnectionStrings:DB_Connection"];
                using (SqlConnection connection = new SqlConnection(connectioString))
                {
                    string sqlQuery = $"sp_detalleProducto @param_ID='{productoModel.id}'";
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
            int valor = (int)HttpContext.Session.GetInt32("variableInt");
            ViewBag.Session = valor;
            ViewBag.Detalle = lista;
            return View();
        }

        public IActionResult AgregarCarrito(int idP, int idU, int cant)
        {
            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                var connection = new SqlConnection(connectionString);
                string sqlQuery = $"exec sp_anadirCarrito @param_CEDULA='{idU}',@param_IDP='{idP}',@param_CANTIDAD='{cant}'";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();
                }
            }
            return new JsonResult("Se agrego al carrito");
        }
        public IActionResult verCarrito()
        {
            int idU = (int)HttpContext.Session.GetInt32("variableInt");
            int precioTemp = 0;
            int subTotalTemp = 0;
            List<object> lista = new List<object>();
            if (ModelState.IsValid)
            {
                string connectioString = Configuration["ConnectionStrings:DB_Connection"];
                using (SqlConnection connection = new SqlConnection(connectioString))
                {
                    string sqlQuery = $"sp_verCarrito @param_IDU='{idU}'";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        connection.Open();
                        SqlDataReader productoReader = command.ExecuteReader();
                        
                        while (productoReader.Read())
                        {
                            precioTemp = Int32.Parse(productoReader["CANTIDAD"].ToString()) * Int32.Parse(productoReader["PRECIO"].ToString());
                            subTotalTemp += precioTemp;
                            ProductoModel productoTemp = new ProductoModel(Int32.Parse(productoReader["IDP"].ToString())
                                                                           ,productoReader["NOMBREP"].ToString()
                                                                           ,Int32.Parse(productoReader["PRECIO"].ToString())
                                                                           , Int32.Parse(productoReader["CANTIDAD"].ToString())
                                                                           , productoReader["FOTO"].ToString()
                                                                           ,precioTemp
                                                                           ,subTotalTemp
                                                                           , Int32.Parse(productoReader["STOCK"].ToString()));
                            lista.Add(productoTemp);
                        }
                        connection.Close();
                    }
                }
            }
            int valor = (int)HttpContext.Session.GetInt32("variableInt");
            ViewBag.Session = valor;
            ViewBag.Carrito = lista;
            ViewBag.SubTotal = subTotalTemp;
            return View();
        }
        public IActionResult UpdateCarrito(int idP, int idU, int cant)
        {
            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                var connection = new SqlConnection(connectionString);
                string sqlQuery = $"exec sp_actualizarCarrito @param_IDP='{idP}',@param_IDU='{idU}',@param_ASC='{cant}'";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();
                }
            }
            return new JsonResult("Se actualizo");
        }

        public IActionResult EliminarCarrito(int idP, int idU)
        {
            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                var connection = new SqlConnection(connectionString);
                string sqlQuery = $"exec sp_eliminarCarrito @param_IDP='{idP}',@param_IDU='{idU}'";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();
                }
            }
            return new JsonResult("");
        }
    }
}

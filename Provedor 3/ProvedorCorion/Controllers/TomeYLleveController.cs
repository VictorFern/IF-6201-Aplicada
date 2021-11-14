using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ProvedorCorion.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ProvedorCorion.Controllers
{
    public class TomeYLleveController : Controller
    {
        public IConfiguration Configuration { get; set; }
        private readonly IHostingEnvironment _webhost;
        public TomeYLleveController(IConfiguration configuration, IHostingEnvironment webhost)
        {
            Configuration = configuration;
            _webhost = webhost;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Listar()
        {
            if (HttpContext.Session.GetInt32("tomeylleve") is null)
            {
                ViewData["Mensaje"] = "Debes de iniciar sesion para continuar";
                return View("Index");
            }
            else
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
                                temp.Categoria = productosReader["CATEGORIA"].ToString();
                                temp.Precio = Int32.Parse(productosReader["PRECIO"].ToString());
                                temp.Dimensiones = productosReader["DIMENSIONES"].ToString();
                                temp.Descripcion = productosReader["DESCRIPCION"].ToString();
                                temp.Foto = productosReader["PIMAGE"].ToString();
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
        [HttpPost]
        public IActionResult LoginKey(AdmiModel temp)
        {
            string clave = temp.Pass;
            var url = $"http://apitomeylleve-001-site1.etempurl.com/api/Productos/login/{clave}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return View("Login");
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            String responseBody = objReader.ReadToEnd();
                            Console.WriteLine(responseBody);
                            String welcome = '"'+"¡Bienvenido!"+'"';
                            Console.WriteLine(welcome);
                            int result = responseBody.CompareTo(welcome);
                            Console.WriteLine(result);
                            if (result==0)
                            {
                                HttpContext.Session.SetInt32("tomeylleve", 1);
                                return View("Index");
                            }
                            else
                            {
                                return View("Login");
                            }
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        [HttpPost]
        public IActionResult GetKey(AdmiModel temp)
        {
            int IdProveedor = 3;
            var url = $"http://apitomeylleve-001-site1.etempurl.com/api/Productos/getkey/{IdProveedor}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return View("Login");
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            Console.WriteLine(responseBody);
                            return View("Login");
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
                return View("Login");
            }
        }
        [HttpPost]
        public IActionResult ListarTomeYLleve()
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
                            temp.Categoria = productosReader["CATEGORIA"].ToString();
                            temp.Precio = Int32.Parse(productosReader["PRECIO"].ToString());
                            temp.Dimensiones = productosReader["DIMENSIONES"].ToString();
                            temp.Descripcion = productosReader["DESCRIPCION"].ToString();
                            temp.Foto = productosReader["PIMAGE"].ToString();
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
        public IActionResult addTomeYLleve(ProductoModel producto)
        {
            string conexionString = Configuration["ConnectionStrings:DB_Connection_Turrialba"];
            var connection = new SqlConnection(conexionString);
            ProductoModel temp = new ProductoModel();
            string sqlQuery = $"exec sp_get_product @param_ID = '{producto.Id}'";
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                command.CommandType = CommandType.Text;
                connection.Open();
                SqlDataReader productosReader = command.ExecuteReader();
                productosReader.Read();
                temp.Id = Int32.Parse(productosReader["ID"].ToString());
                temp.Nombre = productosReader["NOMBRE"].ToString();
                temp.Marca = productosReader["MARCA"].ToString();
                temp.Categoria = productosReader["CATEGORIA"].ToString();
                temp.Precio = Int32.Parse(productosReader["PRECIO"].ToString());
                temp.Dimensiones = productosReader["DIMENSIONES"].ToString();
                temp.Descripcion = productosReader["DESCRIPCION"].ToString();
                temp.Foto = productosReader["PIMAGE"].ToString();
                temp.Cantidad = 2;
                temp.IdProveedor = 3;
                temp.OtrasCaracteristicas = "";
                connection.Close();
            };
            var url = $"http://apitomeylleve-001-site1.etempurl.com/api/Productos/Registro";
            var request = (HttpWebRequest)WebRequest.Create(url);
            string json = JsonConvert.SerializeObject(temp);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return View("Login");
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            Console.WriteLine(responseBody);
                            return View("Index");
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
                return View("Login");
            }
        }
    }
}
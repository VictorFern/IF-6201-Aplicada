using IF6201_TomeYLleve.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace IF6201_TomeYLleve.Controllers
{
    public class UsuarioController : Controller
    {

        public IConfiguration Configuration { get; }

        public UsuarioController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult iniciarSesion()
        {
            HttpContext.Session.SetString("variableSession", "valor en session");
            HttpContext.Session.SetInt32("variableInt", 0);
            return View();
        }

        [HttpPost]
        public IActionResult iniciarSesion(UsuarioModel usuarioModel)
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();
            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = $"exec sp_iniciarSesion @param_ALIAS ='{usuarioModel.alias}', @param_CONTRASENNA ='{usuarioModel.pass}'";
                    using (SqlCommand command = new SqlCommand(sqlQuery,connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        connection.Open();
                        SqlDataReader usuariooReader = command.ExecuteReader();
                        while (usuariooReader.Read())
                        {
                            UsuarioModel usuarioTemp = new UsuarioModel(Int32.Parse(usuariooReader["CEDULA"].ToString())
                                                                        ,usuariooReader["ALIAS"].ToString()
                                                                        ,usuariooReader["TIPO"].ToString());
                            HttpContext.Session.SetInt32("variableInt", usuarioTemp.cedula);
                            usuarios.Add(usuarioTemp);
                        }
                        connection.Close();
                    }
                }
                
            }
            if (usuarios.Count != 0)
            {
                if (usuarios[0].tipo == "Administrador")
                {
                    usuarios.Clear();

                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    usuarios.Clear();
                    return RedirectToAction("Index", "Cliente");
                }

            }
            else
            {
                ViewData["Error"] = "Datos incorrectos";
                return View("iniciarSesion");
            }
        }
        public IActionResult cambiarContrasena()
        {
            return View();
        }
        [HttpPost]
        public IActionResult cambiarContrasena(UsuarioModel usuarioModel)
        {
            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                var connection = new SqlConnection(connectionString);
                string sqlQuery = $"exec sp_cambiar_contrasenna @param_ALIAS='{usuarioModel.alias}', @param_CONTRASENNA='{usuarioModel.pass}'";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();
                }
            }
            return RedirectToAction("iniciarSesion");
        }
    }
}


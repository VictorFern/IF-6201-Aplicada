using IF6201_TomeYLleve.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

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
    }
}

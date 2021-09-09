using Microsoft.AspNetCore.Http;
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
    public class AdmiController : Controller
    {
        public IConfiguration Configuration { get; set; }

        public AdmiController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(AdmiModel admiModel)
        {
            Console.WriteLine(admiModel.Nombre);
            Console.WriteLine(admiModel.Pass);
            string conexionString = Configuration["ConnectionStrings:DB_Connection_Turrialba"];
            var connection = new SqlConnection(conexionString);

            string sqlQuery = $"exec sp_get_admin @param_USUARIO = '{admiModel.Nombre}', " +
                     $"@param_CONTRASENA = '{admiModel.Pass}'";
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                command.CommandType = CommandType.Text;
                connection.Open();
                SqlDataReader admiReader = command.ExecuteReader();
                if (admiReader.Read())
                {
                    //aqui hay que guardar el admi que inicio si mal no recuerdo es con un session
                    connection.Close();
                    return View("Index");
                }
                else
                {
                    //esto es en caso de que no encuentre a ningun admi con ese usuario y contrasenna
                    connection.Close();
                    return View();
                }
            };
        }
    }
}

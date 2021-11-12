using API_TOME_Y_LLEVE.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Configuration;
using System.Web;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace API_TOME_Y_LLEVE.Controllers
{
    [ApiController]
    [Route("api/Productos")]
    public class ProductoController : ControllerBase
    {
        private readonly IConfiguration Configuration;

        public ProductoController(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        [Route("login/{clave}")]
        [HttpGet]
        public async Task<ActionResult<String>> Login(String clave)
        {
            SqlConnection cn = new SqlConnection(Configuration.GetConnectionString("Default"));

            var cmd = new SqlCommand("sp_LOGIN", cn);

            cn.Open();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@param_clave", clave);

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataRow dr = dt.Rows[0];
                string[] allColumns = dr.ItemArray.Select(obj => obj.ToString()).ToArray();
                ArrayList itm = new ArrayList(allColumns);

                String key = itm[0].ToString();

                cn.Close();


                if (clave == key)
                {
                    return "¡Bienvenido!";

                }
                else
                {
                    return key;
                }


            }
        }

        [Route("Registro")]
        [HttpPost]
        public async Task<ActionResult<String>> Registro(Producto producto)
        {

            SqlConnection cn = new SqlConnection(Configuration.GetConnectionString("Default"));

            cn.Open();
            var cmd = new SqlCommand("sp_REGISTROPRODUCTO", cn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@param_MARCA", producto.Marca);
            cmd.Parameters.AddWithValue("@param_NOMBREP", producto.Nombre);
            cmd.Parameters.AddWithValue("@param_DESCRIPCION", producto.Descripcion);
            cmd.Parameters.AddWithValue("@param_PRECIO", (int) producto.Precio);
            cmd.Parameters.AddWithValue("@param_DIMENSION", producto.Dimensiones);
            cmd.Parameters.AddWithValue("@param_OTRASCARACTERISTICAS", producto.OtrasCaracteristicas);
            cmd.Parameters.AddWithValue("@param_FOTO", producto.Foto);
            cmd.Parameters.AddWithValue("@param_CANTIDAD", producto.Cantidad);
            cmd.Parameters.AddWithValue("@param_IDPROVEEDOR", producto.IdProveedor);
            cmd.Parameters.AddWithValue("@param_CATEGORIA", producto.Categoria);

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //DataRow dr = dt.Rows[0];
                //string[] allColumns = dr.ItemArray.Select(obj => obj.ToString()).ToArray();
                //ArrayList itm = new ArrayList(allColumns);

                cn.Close();

                return "registrado";

            }
        }



        [Route("getKey/{IdProveedor}")]
        [HttpGet]
        public async Task<ActionResult<String>> getKey(int IdProveedor)
        {

            SqlConnection cn = new SqlConnection(Configuration.GetConnectionString("Default"));

            var cmd = new SqlCommand("sp_solicitarClave", cn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@param_IDPROVEEDOR", (int)IdProveedor);

            cn.Open();


            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataRow dr = dt.Rows[0];
                string[] allColumns = dr.ItemArray.Select(obj => obj.ToString()).ToArray();
                ArrayList itm = new ArrayList(allColumns);

                String key = itm[0].ToString();

                String correoBD=itm[1].ToString();
                cn.Close();

                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("tomelleveweb123@gmail.com", "Tome&Lleve", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(correoBD); //Correo destino?
                correo.Subject = "Solicitud para envio de clave"; //Asunto
                correo.Body = "Buenas tardes,esta es la contraseña para utilizar en nuestro sistema "+ key
                    +"\n Que tenga un buen dia de parte del equipo:" +
                    "\n \t Tome&Lleve"; //Mensaje del correo
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
                smtp.Port = 25; //Puerto de salida
                smtp.Credentials = new System.Net.NetworkCredential("tomelleveweb@gmail.com", "tomelleveweb123");//Cuenta de correo
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtp.EnableSsl = true;//True si el servidor de correo permite ssl
                smtp.Send(correo);

				
                return key;

            }

        }

    }
}

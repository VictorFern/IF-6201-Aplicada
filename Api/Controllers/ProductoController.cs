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

                cn.Close();

                return key;

            }

        }

    }
}

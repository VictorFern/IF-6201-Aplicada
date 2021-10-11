using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IF6201_TomeYLleve.Models
{
    public class ClienteModel
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string alias { get; set; }
        public string contrasenna { get; set; }

        public ClienteModel()
        {
            this.cedula = 0;
            this.nombre = "";
            this.apellido = "";
            this.alias = "";
            this.contrasenna = "";
        }

        public ClienteModel(int cedula, string nombre, string apellido, string alias, string contrasenna)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.alias = alias;
            this.contrasenna = contrasenna;
        }
    }
}

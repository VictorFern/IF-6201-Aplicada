using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IF6201_TomeYLleve.Models
{
    public class UsuarioModel
    {
        public int cedula { get; set; }
        public string alias { get; set; }
        public string pass { get; set; }
        public string tipo { get; set; }
        public UsuarioModel(int cedula, string alias, string pass, string tipo)
        {
            this.cedula = cedula;
            this.alias = alias;
            this.pass = pass;
            this.tipo = tipo;
        }

        public UsuarioModel(int cedula, string alias, string tipo)
        {
            this.cedula = cedula;
            this.alias = alias;
            this.tipo = tipo;
        }

        public UsuarioModel()
        {
            this.cedula = 0;
            this.alias = "";
            this.pass = "";
            this.tipo = "";
        }



    }
}

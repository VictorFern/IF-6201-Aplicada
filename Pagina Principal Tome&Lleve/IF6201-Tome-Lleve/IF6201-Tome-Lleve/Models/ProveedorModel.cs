using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IF6201_TomeYLleve.Models
{
    public class ProveedorModel
    {
        public int id { get; set; }
        public string proveedor { get; set; }

        public ProveedorModel()
        {
            this.id = 0;
            this.proveedor = "";
        }
        public ProveedorModel(int id, string proveedor)
        {
            this.id = id;
            this.proveedor = proveedor;
        }
    }
}

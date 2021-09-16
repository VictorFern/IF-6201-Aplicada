using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IF6201_TomeYLleve.Models
{
    public class ProductoModel
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }
        public string dimension { get; set; }
        public string otrascaracteristicas { get; set; }
        public string foto { get; set; }
        public int cantidad { get; set; }
        public int categoria { get; set; }
        public int proveedor { get; set; }

        public ProductoModel()
        {
            this.nombre = "";
            this.descripcion = "";
            this.precio = 0;
            this.dimension = "";
            this.otrascaracteristicas = "";
            this.foto = "";
            this.cantidad = 0;
            this.categoria = 0;
            this.proveedor = 0;
        }

        public ProductoModel(string nombre, string descripcion, int precio, string dimension, string otrascaracteristicas, string foto, int cantidad, int categoria, int proveedor)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.dimension = dimension;
            this.otrascaracteristicas = otrascaracteristicas;
            this.foto = foto;
            this.cantidad = cantidad;
            this.categoria = categoria;
            this.proveedor = proveedor;
        }
    }
}

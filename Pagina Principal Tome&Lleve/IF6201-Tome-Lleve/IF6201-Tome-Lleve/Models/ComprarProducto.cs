using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IF6201_TomeYLleve.Models
{
    public class ComprarProducto
    {
        public string numero { get; set; }
        public int codigoSeguridad { get; set; }
        public string tipo { get; set; }
        public string fechaVencimiento { get; set; }
        public ProductoModel productoModel { get; set; }
        public int cantidad { get; set; }
        public int monto { get; set; }
        public string provincia { get; set; }
        public string canton { get; set; }
        public string detalle { get; set; }
        public string direccion { get; set; }

        public ComprarProducto()
        {
            this.numero = "";
            this.codigoSeguridad = 0;
            this.tipo = "";
            this.fechaVencimiento = "";
            this.productoModel = new ProductoModel();
            this.cantidad = 0;
            this.monto = 0;
            this.provincia = "";
            this.canton = "";
            this.detalle = "";
            this.direccion = "";
        }

        public ComprarProducto(ProductoModel productoModel)
        {
            this.productoModel = productoModel;
        }

        public ComprarProducto(string numero, int codigoSeguridad, string tipo, string fechaVencimiento, ProductoModel productoModel, int cantidad, int monto, string provincia, string canton, string detalle)
        {
            this.numero = numero;
            this.codigoSeguridad = codigoSeguridad;
            this.tipo = tipo;
            this.fechaVencimiento = fechaVencimiento;
            this.productoModel = productoModel;
            this.cantidad = cantidad;
            this.monto = monto;
            this.provincia = provincia;
            this.canton = canton;
            this.detalle = detalle;
        }
    }
}

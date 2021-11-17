using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IF6201_TomeYLleve.Models
{
    public class ProductoModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }
        public string dimension { get; set; }
        public string otrascaracteristicas { get; set; }
        public string foto { get; set; }
        public int cantidad { get; set; }
        public CategoriaModel categoriaModel { get; set; }
        public ProveedorModel proveedorModel { get; set; }
        public int precioCantidad { get; set; }
        public int subTotal { get; set; }
        public int stock { get; set; }



        public ProductoModel()
        {
            this.id = 0;
            this.nombre = "";
            this.marca = "";
            this.descripcion = "";
            this.precio = 0;
            this.dimension = "";
            this.otrascaracteristicas = "";
            this.foto = "";
            this.cantidad = 0;
            this.subTotal = 0;
            this.precioCantidad = 0;
            this.categoriaModel = null;
            this.proveedorModel = null;
        }

        public ProductoModel(string nombre, string marca, string descripcion, int precio, string dimension, string otrascaracteristicas, string foto, int cantidad, CategoriaModel categoriaModel, ProveedorModel proveedorModel)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.descripcion = descripcion;
            this.precio = precio;
            this.dimension = dimension;
            this.otrascaracteristicas = otrascaracteristicas;
            this.foto = foto;
            this.cantidad = cantidad;
            this.categoriaModel = categoriaModel;
            this.proveedorModel = proveedorModel;
        }
        public ProductoModel(int id, string nombre, string marca, string descripcion, int precio, string dimension, string otrascaracteristicas, string foto, int cantidad, CategoriaModel categoriaModel, ProveedorModel proveedorModel)
        {
            this.id = id;
            this.nombre = nombre;
            this.marca = marca;
            this.descripcion = descripcion;
            this.precio = precio;
            this.dimension = dimension;
            this.otrascaracteristicas = otrascaracteristicas;
            this.foto = foto;
            this.cantidad = cantidad;
            this.categoriaModel = categoriaModel;
            this.proveedorModel = proveedorModel;
        }

        public ProductoModel(int id, string nombre, int precio, int cantidad,string foto,int precioCantidad, int stock)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.foto = foto;
            this.precioCantidad = precioCantidad;
            this.stock = stock;
        }
    }
}

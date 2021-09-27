using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ProvedorCorion.Models
{
    public class ProductoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public int Precio { get; set; }
        public string Dimensiones { get; set; }
        public string Descripcion { get; set; }
        public string Image { get; set; }
        public ProductoModel()
        {

        }
    }
}

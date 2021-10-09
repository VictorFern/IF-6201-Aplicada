using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IF6201_TomeYLleve.Models
{
    public class CategoriaModel
    {
        public int id { get; set; }
        public string categoria { get; set; }

        public CategoriaModel()
        {
            this.id = 0;
            this.categoria = "";
        }
        public CategoriaModel(int id, string categoria)
        {
            this.id = id;
            this.categoria = categoria;
        }
    }
}

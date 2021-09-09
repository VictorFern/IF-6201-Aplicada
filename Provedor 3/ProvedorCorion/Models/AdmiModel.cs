using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ProvedorCorion.Models
{
    public class AdmiModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pass { get; set; }
        public AdmiModel()
        {
            this.Id = 0;
            this.Nombre = "";
            this.Pass = "";
        }
        public AdmiModel(int id, string nombre, string pass)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Pass = pass;
        }
    }
}
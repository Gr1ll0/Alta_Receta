using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    public class Ingrediente
    {
        public int  IdIngrediente { get; set; }
        public string Nombre { get; set; }
     
        public Ingrediente(int idIngrediente, string nombre)
        {
            IdIngrediente = idIngrediente;
            Nombre = nombre;
         
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    public class Receta
    {
        public int NroReceta { get; set; }
        public string Nombre { get; set; }
        public int TipoReceta { get; set; }
        public string Chef { get; set; }
        public List<DetalleReceta>  DetallesRecetas { get; set; }

        public Receta()
        {
            DetallesRecetas = new List<DetalleReceta>();
        }
        public void AgregarDetalle(DetalleReceta detalle)
        {
            DetallesRecetas.Add(detalle);
        }
        public void QuitarDetalle(int indice)
        {
            DetallesRecetas.RemoveAt(indice);
        }
    }
}

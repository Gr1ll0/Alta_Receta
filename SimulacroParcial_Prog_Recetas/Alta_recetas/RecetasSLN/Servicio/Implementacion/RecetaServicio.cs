using RecetasSLN.Datos.Implementacion;
using RecetasSLN.Datos.Interfaz;
using RecetasSLN.dominio;
using RecetasSLN.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Servicio.Implementacion
{
    public class RecetaServicio:IService
    {
        private IRecetaDao dao;
        public RecetaServicio()
        {
            dao = new RecetaDao();
        }

        public bool ConfirmarPresupuesto(Receta nuevo)
        {
            return dao.GetReceta(nuevo);
        }

        public DataTable ObtenerIngredientes()
        {
            return dao.GetIngredientes();
        }

        public int ProximaReceta()
        {
            return dao.GetProximaReceta();
        }
    }
}

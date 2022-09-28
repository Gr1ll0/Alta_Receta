using RecetasSLN.Datos.Interfaz;
using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Datos.Implementacion
{
    public class RecetaDao : IRecetaDao
    {
        public DataTable GetIngredientes()
        {
            return BD_DAO.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_INGREDIENTES");
        }

        public int GetProximaReceta()
        {
            return BD_DAO.ObtenerInstancia().ConsultarProximo("SP_PROXIMO_ID", "@next");
        }

        public bool GetReceta(Receta nuevo)
        {
            return BD_DAO.ObtenerInstancia().ConfirmarPresupuesto(nuevo);
        }
    }
}

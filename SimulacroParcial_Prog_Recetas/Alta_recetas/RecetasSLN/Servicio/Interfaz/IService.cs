using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Servicio.Interfaz
{
    public interface IService
    {
        bool ConfirmarPresupuesto(Receta nuevo);
        DataTable ObtenerIngredientes();
        int ProximaReceta();
    }
}

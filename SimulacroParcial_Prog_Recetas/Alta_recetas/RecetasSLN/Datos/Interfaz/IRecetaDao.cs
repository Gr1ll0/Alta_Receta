using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Datos.Interfaz
{
    public interface IRecetaDao
    {
        DataTable GetIngredientes();
        int GetProximaReceta();
        bool GetReceta(Receta nuevo);

    }
}

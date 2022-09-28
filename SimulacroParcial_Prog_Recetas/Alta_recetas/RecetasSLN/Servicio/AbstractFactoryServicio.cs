using RecetasSLN.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Servicio
{
    abstract class AbstractFactoryServicio
    {
        public abstract IService CrearServicio();
    }
}

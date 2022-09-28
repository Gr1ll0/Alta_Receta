using RecetasSLN.Servicio.Implementacion;
using RecetasSLN.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Servicio
{
    class ImpFactoryServicio : AbstractFactoryServicio
    {
        public override IService CrearServicio()
        {
            return new RecetaServicio();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion02PatronesDeDiseño.TemplateMethod
{
    abstract class TarjetaPago
    {
        public bool pagaCompra(int importe)
        {
            if (autorizaPago(importe))
            {
                descontarSaldo(importe);
                return true;
            }
            return false;
        }

        public abstract bool autorizaPago(int importe);

        protected abstract void descontarSaldo(int importe);
    }
}

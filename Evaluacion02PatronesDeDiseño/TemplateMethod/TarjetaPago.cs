using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion02PatronesDeDiseño.TemplateMethod
{
    abstract class TarjetaPago
    {
        protected int cuotas;
        public bool pagaCompra(int importe)
        {
            if (autorizaPago(importe))
            {
                descontarSaldo(importe / cuotas);
                return true;
            }
            return false;
        }

        public abstract bool autorizaPago(int importe);

        public abstract void elegirCuotas(int nCuotas);

        protected abstract void descontarSaldo(int importe);
    }
}

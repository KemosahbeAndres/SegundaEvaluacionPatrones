using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion02PatronesDeDiseño.Default
{
    class TarjetaCredito
    {
        protected int cupo;
        protected int deuda;

        public TarjetaCredito(int limite, int deuda)
        {
            this.cupo = limite;
            this.deuda = deuda;
        }

        public void pagaCompra(int importe)
        {
            deuda += importe;
        }

        public bool autorizaPago(int importe)
        {
            return (deuda + importe) <= cupo;
        }

        public override string ToString()
        {
            return $"[CREDITO] DEUDA: ${deuda} | CUPO TOTAL: ${cupo}";
        }
    }
}

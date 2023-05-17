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
        protected int cuotas;

        public TarjetaCredito(int limite, int deuda)
        {
            this.cupo = limite;
            this.deuda = deuda;
            this.cuotas = 1;
        }

        public void pagaCompra(int importe)
        {
            deuda += importe / cuotas;
        }

        public void elegirCuotas(int cuotas)
        {
            this.cuotas = cuotas;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion02PatronesDeDiseño
{
    class TarjetaDebito: TarjetaPago
    {
        protected Cuenta cuentaAsociada;

        public TarjetaDebito(int saldo)
        {
            cuentaAsociada = new Cuenta();
            cuentaAsociada.saldo = saldo;
        }

        public override void pagaCompra(int importe)
        {
            cuentaAsociada.saldo -= importe;
        }

        public override bool autorizaPago(int importe)
        {
            return cuentaAsociada.saldo >= importe;
        }

        public override string ToString()
        {
            return $"[DEBITO] SALDO: ${cuentaAsociada.saldo}";
        }
    }
}

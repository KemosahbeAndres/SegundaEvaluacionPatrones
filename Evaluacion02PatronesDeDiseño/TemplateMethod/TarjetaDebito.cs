using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion02PatronesDeDiseño.TemplateMethod
{
    class TarjetaDebito: TarjetaPago
    {
        protected Cuenta cuentaAsociada;

        public TarjetaDebito(int saldoInicial)
        {
            cuentaAsociada = new Cuenta();
            cuentaAsociada.saldo = saldoInicial;
        }

        public override bool autorizaPago(int importe)
        {
            return cuentaAsociada.saldo >= importe;
        }

        protected override void descontarSaldo(int importe)
        {
            cuentaAsociada.saldo -= importe;
        }

        public override string ToString()
        {
            return $"[DEBITO] SALDO: ${cuentaAsociada.saldo}";
        }

        public override void elegirCuotas(int nCuotas)
        {
            this.cuotas = 1;
        }
    }
}

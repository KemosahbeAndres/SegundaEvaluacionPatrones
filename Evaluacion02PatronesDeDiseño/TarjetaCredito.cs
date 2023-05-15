using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion02PatronesDeDiseño
{
    class TarjetaCredito: TarjetaPago
    {
        protected int limite;
        protected int encurso;

        public TarjetaCredito(int limite, int saldo)
        {
            this.limite = limite;
            this.encurso = saldo;
        }

        public override void pagaCompra(int importe)
        {
            encurso -= importe;
        }

        public override bool autorizaPago(int importe)
        {
            return (encurso + importe) <= limite;
        }

        public override string ToString()
        {
            return $"[CREDITO] SALDO: ${encurso} | LIMITE: ${limite}";
        }
    }
}

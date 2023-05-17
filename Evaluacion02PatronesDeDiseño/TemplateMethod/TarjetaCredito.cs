
namespace Evaluacion02PatronesDeDiseño.TemplateMethod
{
    class TarjetaCredito : TarjetaPago
    {
        protected int cupo;
        protected int deuda;

        public TarjetaCredito(int deuda, int limite) : base()
        {
            this.cupo = limite;
            this.deuda = deuda;
        }

        public override bool autorizaPago(int importe)
        {
            return deuda + importe <= cupo;
        }

        protected override void descontarSaldo(int importe)
        {
            deuda += importe;
        }

        public override string ToString()
        {
            return $"[CREDITO] SALDO: ${deuda} | LIMITE: ${cupo}";
        }

        public override void elegirCuotas(int cuotas)
        {
            if(cuotas > 0)
            {
                this.cuotas = cuotas;
            }
        }
    }
}

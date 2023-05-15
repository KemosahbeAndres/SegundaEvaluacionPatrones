
namespace Evaluacion02PatronesDeDiseño.TemplateMethod
{
    class TarjetaCredito : TarjetaPago
    {
        protected int limite;
        protected int encurso;

        public TarjetaCredito(int saldoInicial, int limite)
        {
            this.limite = limite;
            this.encurso = saldoInicial;
        }

        public override bool autorizaPago(int importe)
        {
            return encurso + importe <= limite;
        }

        protected override void descontarSaldo(int importe)
        {
            encurso -= importe;
        }

        public override string ToString()
        {
            return $"[CREDITO] SALDO: ${encurso} | LIMITE: ${limite}";
        }
    }
}

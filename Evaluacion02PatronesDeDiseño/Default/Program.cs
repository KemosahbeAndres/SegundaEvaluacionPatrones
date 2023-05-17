using System;

namespace Evaluacion02PatronesDeDiseño.Default
{
    class Program
    {
        static void Main(string[] args)
        {
            TarjetaDebito debito = new TarjetaDebito(10000);
            TarjetaCredito credito = new TarjetaCredito(20000, 10000);

            int precio1 = 4000;
            int precio2 = 10000;

            Console.WriteLine("##### COMPRA DEBITO #####");
            Console.WriteLine(debito);
            if (debito.autorizaPago(precio1))
            {
                debito.pagaCompra(precio1);
                Console.WriteLine("Compra exitosa!!");
            }
            else
            {
                Console.WriteLine("## Saldo insuficiente! ##");
            }
            Console.WriteLine(debito);
            Console.WriteLine("##### COMPRA DEBITO #####\n");

            Console.WriteLine("##### COMPRA CREDITO #####");
            Console.WriteLine(credito);
            if (credito.autorizaPago(precio2))
            {
                credito.pagaCompra(precio2);
                Console.WriteLine("Compra exitosa!!");
            }
            else
            {
                Console.WriteLine("## Cupo excedido! ##");
            }
            Console.WriteLine(credito);
            Console.WriteLine("##### COMPRA CREDITO #####");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion02PatronesDeDiseño.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TarjetaDebito debito = new TarjetaDebito(10000);
            TarjetaCredito credito = new TarjetaCredito(10000, 20000);

            int precio1 = 4000;
            int precio2 = 6000;

            Console.WriteLine("##### COMPRA DEBITO #####");
            Console.WriteLine(debito);

            if (debito.pagaCompra(precio1))
            {
                Console.WriteLine("Compra exitosa!!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!!");
            }

            Console.WriteLine(debito);
            Console.WriteLine("##### COMPRA DEBITO #####\n");

            Console.WriteLine("##### COMPRA CREDITO #####");
            Console.WriteLine(credito);

            if (credito.pagaCompra(precio2))
            {
                Console.WriteLine("Compra exitosa!!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!!");
            }

            Console.WriteLine(credito);
            Console.WriteLine("##### COMPRA CREDITO #####");

            Console.ReadLine();
        }
    }
}

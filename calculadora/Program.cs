using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("valor investido");
            var cc1 = Console.ReadLine();
            Console.WriteLine("numero meses");
            var cc2 = Console.ReadLine();
            Console.WriteLine("taxa de juros ao mês");
            var cc4 = Console.ReadLine();
            Console.WriteLine("aportes");
            var cc3 = Console.ReadLine();



            double valorInicial = Convert.ToDouble(cc1);
            double aporte = Convert.ToDouble(cc3);
            double taxa = Convert.ToDouble(cc4);
            taxa = taxa / 100;
            int meses = Convert.ToInt32(cc2);


            double montante = 0;
            montante = valorInicial + (valorInicial * taxa);
            Console.WriteLine("Mes " + 1 + " RS: " + Math.Round(montante, 2));
            for (int i = 2; i <= meses; i++ )
            {
                montante = montante + aporte + montante * taxa;
                Console.WriteLine("Mes " + i + " RS: " + Math.Round(montante, 2));
            }
            Console.ReadKey();

        }
    }
}

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
            decimal valorInicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("numero meses");
            int meses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("taxa de juros ao mês");
            decimal taxa = (Convert.ToDecimal(Console.ReadLine()) / 100);
            Console.WriteLine("aportes");
            decimal aporte = Convert.ToDecimal(Console.ReadLine());
            decimal montante = 0;

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

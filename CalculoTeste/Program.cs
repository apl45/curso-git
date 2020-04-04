using System;
using System.Globalization;

namespace CalculoTeste
{
    class Program
    {
        static void Main(string[] args)
        {

            // entrada de dados
            Console.WriteLine("Entre com dois números para as operações ");
            Console.Write("digite o primeiro: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // operações ( processamento )
            double soma = n1 + n2;
            double sub = n1 - n2;
            double mult = n1 * n2;
            double div = n1 / n2;
            double res = n1 % n2;


            // saída de dados
            Console.WriteLine("-------------------------");
            Console.WriteLine("Soma..........= " + soma.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Subtração.....= " + sub.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Multiplicação.= " + mult.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Divisão.......= " + div.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Resto.........= " + res.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("-------------------------");
        }
    }
}

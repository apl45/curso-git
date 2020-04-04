using System;
using System.Globalization;

namespace CalculoTeste {
    class Program {
        static void Main(string[] args) {

            // entrada de dados
            Console.WriteLine("Entre com dois números para as operações ");
            Console.Write("digite o primeiro: ");
            double n1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // operações ( processamento )
            double soma = n1 + n2;


            // saída de dados
            Console.WriteLine("soma =  " + soma.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}

using System;

namespace AtividadeGritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoDigitado;
            Console.Write("Digite algo:");
            textoDigitado = Console.ReadLine();

            Console.WriteLine($"Você digitou:{textoDigitado.ToUpper()}");
        }
    }
}

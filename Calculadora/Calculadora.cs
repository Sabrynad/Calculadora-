using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            int x = 0; int y = 0;

            Console.WriteLine("Olá tudo bem?");
            

            Console.WriteLine("Insira um numero, e prossiga com seu calculo:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira mais um numero, e pressiga com seu calculo: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha uma opção de de calculo:");
            Console.WriteLine("\ts - Somar");
            Console.WriteLine("\tu - Subitrair");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");

            Console.Write("Qual sua escolha? ");

            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine($"O resultado da sua soma é: {x} + {y} = " + (x + y));
                    break;
                case "u":
                    Console.WriteLine($"O resultado da sua subtração é: {x} - {y} = " + (x - y));
                    break;
                case "m":
                    Console.WriteLine($"O resultado da sua multiplicação é: {x} * {y} = " + (x * y));
                    break;
                case "d":
                    Console.WriteLine($"O resultado da sua divisão é: {x} / {y} = " + (x / y));
                    break;


            }
            Console.Write("Tecle enter para parar  sua calculadora. ");
            Console.ReadKey();

        }
    }
}

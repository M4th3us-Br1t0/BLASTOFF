using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, durou;
            Console.WriteLine("Digite a hora do começo da partida: ");
            float.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Digite a hora do termino da partida: ");
            float.TryParse(Console.ReadLine(), out b);

            durou = b - a;



            Console.WriteLine("A partida durou "+ durou +" horas");
        }
    }
}
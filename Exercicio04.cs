using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            float c, f;
            Console.WriteLine("Digite a temperatura em C°: ");
            float.TryParse(Console.ReadLine(), out c);

            f = (float)(c * 1.8 + 32);

            Console.WriteLine("A temperatura "+ c +"C° em Fahrenheit é: "+ f +"F°");
        }
    }
}

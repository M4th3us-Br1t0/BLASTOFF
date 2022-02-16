using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, consumo;
            Console.WriteLine("Digite a distacia percorrida: ");
            float.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Digite o combustivel gasto: ");
            float.TryParse(Console.ReadLine(), out b);

            consumo=a/b;

            Console.WriteLine("Seu carro consome 1 litro a cada"+ consumo +" Km");
        }
    }
}
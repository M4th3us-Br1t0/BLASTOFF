using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, menor = 0;
            Console.WriteLine("Digite o primeiro número: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Digite o terceiro número: ");
            int.TryParse(Console.ReadLine(), out c);

            if(a<b)
            {
                if(a<c)
                {
                    menor = a;
                }
                else
                {
                    menor = c;
                }
            }
            Console.WriteLine("O menor valor entre os três é: "+ menor);
        }
    }
}

using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Digite o primeiro número: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Digite o  segundo número: ");
            int.TryParse(Console.ReadLine(), out b);

            if(a>b && (a%b) == 0){
                Console.WriteLine("Os números "+ a +" e "+ b +" são multiplos!");
            }
            else{
                Console.WriteLine("Os números "+ a +" e "+ b +" não são multiplos!");
            }
        }
    }
}

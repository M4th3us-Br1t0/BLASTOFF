using System;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i, valor;
            Console.WriteLine("Digite aum valor: ");
            int.TryParse(Console.ReadLine(), out x);

            for(i = 0; i <= 10; i++ ){
                valor = x * i;
                Console.WriteLine(+x+ "X" + i + "="+ valor);

            }

            

            

        }
    }
}
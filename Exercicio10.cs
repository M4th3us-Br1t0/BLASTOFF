using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, fatorial, resultado = 1;
            Console.WriteLine("Digite aum valor maior que zero: ");
            int.TryParse(Console.ReadLine(), out numero);

           for(fatorial = 1; fatorial <= numero; fatorial ++){
               resultado = resultado * fatorial;
           }

            Console.WriteLine("O fatorial de "+ numero+ " é: "+ resultado);

            

            

        }
    }
}
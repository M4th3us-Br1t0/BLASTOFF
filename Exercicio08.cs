using System;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, valor = 1, divisores = 0;
            Console.WriteLine("Digite aum valor: ");
            int.TryParse(Console.ReadLine(), out x);

            if(x > 0){
                while(valor <= x){
                    if((x % valor) == 0){
                        divisores++;
                    }
                    valor++;
                }
                if(divisores == 2){
                    Console.WriteLine("O número "+ x +" é primo!");
                }
                else{
                    Console.WriteLine("O número "+ x +" não é primo!");
                }
                
            }
            else{
                Console.WriteLine("Erro: Valor negativo ou igual a zero!");
            }
        }
    }
}
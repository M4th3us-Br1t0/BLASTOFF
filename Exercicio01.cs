using System;

namespace ConsoleApplicationVSCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,k,x,y,media;
            Console.WriteLine("Digite a primeira nota: ");
            int.TryParse(Console.ReadLine(), out i);
            Console.WriteLine("Digite a segunda nota: ");
            int.TryParse(Console.ReadLine(), out j);
            Console.WriteLine("Digite a terceira nota: ");
            int.TryParse(Console.ReadLine(), out k);
            Console.WriteLine("Digite a quarta nota: ");
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Digite a quinta nota: ");
            int.TryParse(Console.ReadLine(), out y);

            media=(i+j+k+x+y)/5;

            Console.WriteLine("Média: "+ media);
        }
    }
}
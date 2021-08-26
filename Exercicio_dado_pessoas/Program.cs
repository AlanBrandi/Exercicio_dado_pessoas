using System;

namespace Exercicio_dado_pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas x, y;

            x = new Pessoas();
            y = new Pessoas();

            Console.WriteLine("Digite os dados da primeira pessoa(Nome e idade, respectivamente):");
            x.nome = Console.ReadLine();
            x.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da segunda pessoa(Nome e idade, respectivamente):");
            y.nome = Console.ReadLine();
            y.idade = int.Parse(Console.ReadLine());

            if (x.idade > y.idade)
            {
                Console.WriteLine("A pessoa mais velha é: " + x.nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é: " + y.nome);
            }
        }
    }
}

using System;

namespace Exercicio_Tres
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            float media = 0f;
            int idade = 0;
            int soma = 0;
            int idadeMaior = 0;
            int idadeMenor = 0;

            do
            {
                Console.WriteLine("Digite uma idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade != 0)
                {
                    if (idade > idadeMaior)
                        idadeMaior = idade;
                    else
                        idadeMenor = idade;
                    soma = soma + idade;
                    n++;
                }
            }
            while (idade != 0);

            media = soma / n;
            Console.WriteLine("A média de idade é: {0:f1}", media);
            Console.WriteLine("A maior idade é: {0}", idadeMaior);
            Console.WriteLine("A menor idade é: {0}", idadeMenor);
            Console.ReadKey();
        }
    }
}

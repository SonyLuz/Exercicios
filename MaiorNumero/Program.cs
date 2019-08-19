using System;
using System.Collections.Generic;
using System.Linq;

namespace MaiorNumero
{
    class Program
    {
        static void Main(string[] args)
        {

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Digite 's' para gerar numeros e resultado e 'n' para sair.");

                continuar = Console.ReadLine().Equals("n") ? false : true;

                if(continuar)
                {
                    Random randNum = new Random();
                    int[] numInt = new int[10];

                    for (int i = 0; i < numInt.Count(); i++)
                        numInt[i] = randNum.Next(100);

                    string lista = string.Join(',', numInt);
                    int maiorNum = numInt.ToList().Max();

                    Console.WriteLine($"lista de inteiros: {lista}");
                    Console.WriteLine($"maior numero da lista: {maiorNum}\n");
                }
                else
                {
                    Console.WriteLine("Vlw");
                    return;
                }
                

            }
            Console.ReadKey();
        }
    }
}

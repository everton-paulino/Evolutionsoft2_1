using System;

namespace Evolutionsoft2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Razao = 1;
            int Inicio = 1;

            Console.WriteLine("Digite um número");
            int Termino = int.Parse(Console.ReadLine());

            int Soma = 0;

            int Pa = Inicio;
            Console.Write(" A soma dos números ");

            for (int i = Inicio; i <= Termino; i += Razao)
            {
                Console.Write(Pa + ",");
                Soma += Pa;
                Pa += Razao;

            }
            Console.Write(" é igual " + Soma);
            Console.ReadLine();
        }
    }
}

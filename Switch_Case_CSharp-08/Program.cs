using System;

namespace Switch_Case_CSharp_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int diasemana;

            Console.WriteLine("Digite o número correspondente ao dia da semana:");
            diasemana = int.Parse(Console.ReadLine());

            switch (diasemana)
            {
                case 1:
                    Console.WriteLine("Hoje é Domingo!");
                    break;
                case 2:
                    Console.WriteLine("Hoje é Segunda-Feira!");
                    break;
                case 3:
                    Console.WriteLine("Hoje é Terça-Feira!");
                    break;
                case 4:
                    Console.WriteLine("Hoje é Quarta-Feira!");
                    break;
                case 5:
                    Console.WriteLine("Hoje é Quinta-Feira!");
                    break;
                case 6:
                    Console.WriteLine("Hoje é Sexta-Feira!");
                    break;
                case 7:
                    Console.WriteLine("Hoje é Sábado!");
                    break;
            }
        }
    }
}

using System;

namespace Exercicios_fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("Digite o ano atual: ");
            int anoAtual = int.Parse(Console.ReadLine());;

            Console.WriteLine("Digite a data de nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());
            
            int validacao = anoAtual - nascimento;

            if(validacao == 18){
                Console.WriteLine("Você tem que votar esse ano.");
            if(validacao > 16){
                Console.WriteLine("Seu Voto é opcional");
                }
            } else {
                Console.WriteLine("Você não pode votar esse ano.");
            }
        }
    }
}

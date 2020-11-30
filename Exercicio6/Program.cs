using System;

namespace Exercicios_fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
              string[] nomes = new string [10];
            string mensagem = "NÃO ACHEI";

            Console.WriteLine("Escreva 10 nomes abaixo");
            Console.WriteLine("-----------------------");
            for(int i = 0; i < nomes.Length; i++) {
                System.Console.Write($"{i+1}º nome: ");
                nomes[i] = Console.ReadLine();
            }

            System.Console.Write("Agora digite um nome para pesquisar em nosso banco de dados: ");
            string procurandoNome = Console.ReadLine();

            for(int i = 0; i < nomes.Length; i++) {
               if(nomes[i] == procurandoNome){
                   mensagem = "ACHEI";
               }
            }

            System.Console.WriteLine(mensagem);
        }
    }
}

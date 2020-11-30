using System;

namespace Exercicios_fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
              double litroGasolina = 5.3;
            double litroAlcool = 4.9;

            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("-------------{ Opções }------------");
            Console.ResetColor();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" (A) Álcool                        ");
            Console.WriteLine(" (G) Gasolina                      ");
            Console.WriteLine("-----------------------------------");
            string tipoCombustivel = Console.ReadLine();

            while(tipoCombustivel.ToUpper() != "A" && tipoCombustivel.ToUpper() != "G"){
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Por Favor Digite apenas as opções válidas");
                Console.ResetColor();
                Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("-------------{ Opções }------------");
            Console.ResetColor();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" (A) Álcool                        ");
            Console.WriteLine(" (G) Gasolina                      ");
            Console.WriteLine("-----------------------------------");
            }

            Console.Write("Digite a quantidade de litros: ");
            double litros = double.Parse(Console.ReadLine());

            
            switch(tipoCombustivel.ToUpper()){
                case "A":
                    CalcularPrecoAlcool(litroAlcool, litros);
                    break;
                case "G":
                    CalcularPrecoGasolina(litroGasolina, litros);
                    break;
                default:
                    break;
            }
        }

        static void CalcularPrecoGasolina(double litroGasolina, double litros){
            double valor = 0;

            double desconto1 = (litroGasolina * litros) * 0.04;
            double desconto2 = (litroGasolina * litros) * 0.06;

            switch(litros){
                case double n when n <= 20:
                    valor = (litroGasolina * litros) - desconto1;
                    break;
                case double n when n > 20:
                    valor = (litroGasolina * litros) - desconto2;
                    break;
                default:
                    break;
            }

            System.Console.WriteLine($"O valor total a ser pago é de R${valor}");
        }

        static void CalcularPrecoAlcool(double litroAlcool, double litros){
            double valor = 0;
            
            double desconto1 = (litroAlcool * litros) * 0.03;
            double desconto2 = (litroAlcool * litros) * 0.05;

            switch(litros){
                case double n when n <= 20:
                    valor = (litroAlcool * litros) - desconto1;
                    break;
                case double n when n > 20:
                    valor = (litroAlcool * litros) - desconto2;
                    break;
                default:
                    break;
            }

            System.Console.WriteLine($"O valor total a ser pago é de R${valor}");
        }
    }
}

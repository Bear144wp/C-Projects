using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Qual operação deseja fazer?");
                Console.WriteLine("1- Adição");
                Console.WriteLine("2- Subtração");
                Console.WriteLine("3- Multiplicação");
                Console.WriteLine("4- Divisão");
                Console.WriteLine("5- Sair\n");

                int operacao = int.Parse(Console.ReadLine());

                if (operacao == 5)
                {
                    Console.WriteLine("Encerrando o programa...");
                    break;
                }

                Console.WriteLine("Digite o primeiro número");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número");
                int num2 = int.Parse(Console.ReadLine());

                int resultado = 0;

                switch (operacao)
                {
                    case 1:
                        resultado = Adicao(num1, num2);
                        break;

                    case 2:
                        resultado = Subtracao(num1, num2);
                        break;

                    case 3:
                        resultado = Multiplicacao(num1, num2);
                        break;

                    case 4:
                        resultado = Divisao(num1, num2);
                        break;

                    default:
                        Console.WriteLine("Número inválido, digite outro número");
                        break;
                }

                Console.WriteLine("O resultado da operação com os números {0} e {1} é: {2}", num1, num2, resultado);

                Console.WriteLine("\nDeseja fazer outro cálculo? (S/N)");
            } while (Console.ReadLine().ToUpper() == "S");
        }

        public static int Adicao(int numero1, int numero2)
        {
            int result = numero1 + numero2;
            return result;
        }

        public static int Subtracao(int numero1, int numero2)
        {
            int result = numero1 - numero2;
            return result;
        }

        public static int Multiplicacao(int numero1, int numero2)
        {
            int result = numero1 * numero2;
            return result;
        }

        public static int Divisao(int numero1, int numero2)
        {
            int result = numero1 / numero2;
            return result;
        }
    }
}
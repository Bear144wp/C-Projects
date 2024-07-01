using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Jogo de adivinhação, que gera um número aleatorio de 0 a 100 e o usuario precisa adivinhar, o jogo conta o numeros de tentativas até o acerto
            e da dicas a cada tentativa se o número é maior ou menor*/
            Random random = new Random();

            int numeroaleatorio = random.Next(0, 101);
            int tentativas = 0;

            Console.WriteLine("Voce precisa adivinhar o número entre 0 e 100, vou te dar algumas dicas, comece suas tentativas: ");
            while (true)
            {
                Console.WriteLine($"Tentativa: {tentativas}");
                int entrada = Convert.ToInt32(Console.ReadLine());
                tentativas++;
                if (entrada == numeroaleatorio)
                {
                    Console.WriteLine("Parabens voce acertou!");
                    break;
                }
                else if (entrada != numeroaleatorio)
                {
                    if (entrada > numeroaleatorio)
                    {
                        Console.WriteLine("O número é menor!");
                    }
                    else
                    {
                        Console.WriteLine("O número é maior!");
                    }
                }
                
            }
            Console.WriteLine("Pressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}

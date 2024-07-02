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
            Console.WriteLine("Digite a data e hora no seguinte formato para ver quantos dias faltam: 01/07/2024 23:45");
            string entrada = Console.ReadLine();
            DateTime convertida = Convert.ToDateTime(entrada);
            DateTime agora = DateTime.Now;

            TimeSpan calculo = convertida - agora;
            int conversaotime = Convert.ToInt32(calculo.TotalDays);

            Console.WriteLine($"Faltam apenas: {conversaotime} dias!");


            Console.WriteLine("Pressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}

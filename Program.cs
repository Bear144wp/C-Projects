using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_código_do_curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo, digite as seguintes informações: ");
            Console.WriteLine("Digite seu primeiro nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Agora digite sua idade: ");
            UInt16 idade = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Informe seu número do documento: ");
            string documento = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o nome da sua rua: ");
            string nomedarua = Console.ReadLine();
            Console.WriteLine("Digite o numero da sua casa: ");
            UInt16 numerodacasa = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Informe seu gênero com M/F: ");
            string genero = Console.ReadKey(true).KeyChar.ToString();

            Console.WriteLine($"Seja bem vindo!\n Seu nome é {nome}\n Você tem {idade} anos\n O número do seu docuemnto é {documento}\n " +
                $"O nome da sua rua é {nomedarua}, e numero da casa {numerodacasa}\n e seu gênero é {genero}");

            Console.WriteLine("Digite algo para finalizar");
            Console.ReadKey();  
        }
    }
}

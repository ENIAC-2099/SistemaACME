using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaACME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuarioBob = new Usuario("Bob Nelson", 37, 1.70F, 78F); 
            Usuario usuarioTestolfo = new Usuario("Testolfo", 43, 1.65F, 60F);
            Usuario usuarioLisa = new Usuario("Lisa Leite", 22, 1.72F, 92F);

            Console.WriteLine("Bob");
            usuarioBob.DescricaoIMC();
            Console.ReadLine();

            Console.WriteLine("Testolfo");
            usuarioTestolfo.DescricaoIMC();
            Console.ReadLine();

            Console.WriteLine("Lisa");
            usuarioLisa.DescricaoIMC();
            Console.ReadLine();
        }
    }
}

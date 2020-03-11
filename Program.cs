using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            jogo.Gameplay();
            Console.WriteLine("Tecle para sair");
            Console.ReadKey();
        }
    }
}

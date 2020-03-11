using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forca2
{
    class Jogo
    {
        List<string> Palavras = new List<string> { "Apartamento", "Hospital", "Computador", "Futebol","Refrigerante","Casa","Chuva","Sapato","Professora" };
        public string Palavra { get; set; }
        public List<string> PalavraEscondida;//lista
        string Escondida { get; set; }
        bool Jogando = true;
        int Chances = 4;
        public void OcultaPalavra()
        {
            PalavraEscondida = new List<string>();
            foreach (var letra in Palavra)
            {
                PalavraEscondida.Add("_");
            }
            
        }
        public void DefinePalavra()
        {

            Random random = new Random();
            int index = random.Next(0,Palavras.Count-1);
            Palavra = Palavras[index];
            OcultaPalavra();
            
        }


        public void Gameplay()
        {
            DefinePalavra();

            while (Jogando)
            {

                Escondida = String.Concat(PalavraEscondida);                
                if (Escondida.ToLower() != Palavra.ToLower())
                {
                    Console.WriteLine(Escondida + "\n" + $"Você tem {Chances}chances");
                    string letra = Console.ReadLine();

                    if (Palavra.ToLower().Contains(letra))
                    {
                        for (int i = 0; i < Palavra.Length; i++)
                        {

                            if (Palavra[i].ToString().ToLower() == letra.ToLower())
                            {
                                PalavraEscondida[i] = letra;
                            }

                        }
                        Console.WriteLine("Acertou!");
                        Som.Acertou();
                    }
                    else
                    {
                        Chances--;
                        Console.WriteLine("Errou!Perdeu uma chance");
                        Som.Errou();
                        if (Chances == 0)
                        {
                            Console.WriteLine("Perdeu o jogo! Que pena");
                            Console.WriteLine($"{Palavra}");
                            Jogando = false;
                            Som.Perdeu();
                        }
                    }
                }
                else
                {
                    Som.Ganhou();
                    Console.WriteLine(Palavra);
                    Console.WriteLine("Parabéns! Você ganhou o jogo");
                     Jogando = false;

                }
            }
        }
    }
}

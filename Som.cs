using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
namespace Forca2
{
    public static class Som
    {
        static SoundPlayer player = new SoundPlayer();
        static string pasta = Directory.GetDirectoryRoot("Forca2");
        static string pastaProjeto = pasta + @"Forca2\Forca2\Sons\";
        public static void Acertou()
        {
            player.SoundLocation = pastaProjeto+"Acertou.wav";
            player.PlaySync();
        }
        public static void Errou()
        {
            player.SoundLocation = pastaProjeto + "Errou.wav";
            player.PlaySync();
        }
        public static void Ganhou()
        {
            player.SoundLocation = pastaProjeto + "GanhouJogo.wav";
            player.PlaySync();
        }
        public static void Perdeu()
        {
            player.SoundLocation = pastaProjeto + "PerdeuJogo.wav";
            player.PlaySync();
        }


    }
}

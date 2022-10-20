using System;
using Encapsulamento;

namespace CursoCSharp.OO {

    public class FilhoNaoReconhecido : Subcelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("Filho não reconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(JeitoDeFalar);

        }
    }

    public class AmigoDistante {
        public readonly Subcelebridade amiga = new Subcelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo Distante...");
            Console.WriteLine(amiga.InfoPublica);

        }
    }

    class Encapsulamento {
        public static void Executar() {
            Subcelebridade sub = new Subcelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}

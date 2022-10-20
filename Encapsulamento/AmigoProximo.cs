using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class AmigoProximo {
        public readonly Subcelebridade amiga = new Subcelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo próximo...");
            Console.WriteLine(amiga.InfoPublica);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class FilhoReconhecido: Subcelebridade {

        public new void MeusAcessos() {
            Console.WriteLine("Filho reconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class Subcelebridade {
        //Todos
        public string InfoPublica = "Tenho um instagram!";

        //herança
        protected string CorDosOlhos = "verde";

        //mesmo projeto (assemply)
        internal ulong NumeroCelular = 5511999999999;

        //herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //mesma classe ou por herança no mesmo projeto (c# >= 7.2)
        private protected string SegredoDeFamilia = "Bla bla bla";

        //private padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("Subcelebridade.....");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }

    }
}

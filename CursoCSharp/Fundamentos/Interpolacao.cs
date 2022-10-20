using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "Notebook Gamer";
            string marcar = "Dell";
            double preco = 5800.00;
            Console.WriteLine("Um {0} da marca {1} custa {2}", nome, marcar, preco);
            Console.WriteLine($"A marca {marcar} é legal.");
        }
    }
}

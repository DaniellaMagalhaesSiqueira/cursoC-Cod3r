using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Igualdade {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;
            Console.WriteLine(p1 == p2); //false
            Console.WriteLine(p3 == p2); //true
            Console.WriteLine(p1.Equals(p2)); //false se não tiver Equals implementado em Produto
            /*
             * Coleções que aceitam repetições método Equals resolve
             * Coleções que não aceitam repetições método GetHashCode
             * @see ColecoesList - classe Produto
             */
        }
    }
}

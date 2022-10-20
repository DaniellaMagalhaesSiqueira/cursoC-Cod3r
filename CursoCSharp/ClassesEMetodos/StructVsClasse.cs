using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }

    class StructVsClasse {
        public static void Executar() {
            SPonto p1 = new SPonto { X = 1, Y = 3 };
            SPonto copiap1 = p1;//atribuição por valor x aqui é 1 e não muda se alterar p1
            p1.X = 3;
            Console.WriteLine("Ponto 1: X = {0}", p1.X);
            Console.WriteLine("Cópia do ponto 1: X = {0}", copiap1.X);

            CPonto p2 = new CPonto { X = 2, Y = 4 };
            CPonto copiap2 = p2;//atribuição por referencia
            p2.X = 4; //muda também a cópia pq apontam para o mesmo local de memória

            Console.WriteLine("Ponto 2: X = {0}", p2.X);
            Console.WriteLine("Cópia do ponto 2: X = {0}", copiap2.X);
        }
    }
}

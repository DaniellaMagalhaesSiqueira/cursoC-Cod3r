using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {

    public static class ExtensoesInteiro {
        public static int Soma(this int num, int outroNum) {
            return num + outroNum;
        }

        public static double Subtracao(this double num, double outro) {
            return num - outro;
        }
    }
    class MetodosDeExtensao {
        public static void Executar() {
            int num = 5;
            double num2 = 5.5;
            Console.WriteLine(num.Soma(3));
            Console.WriteLine(num2.Subtracao(10));

            Console.WriteLine(4.Soma(3));
            Console.WriteLine(8.0.Subtracao(10));

        }
    }
}

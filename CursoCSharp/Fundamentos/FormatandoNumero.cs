using System;
using System.Globalization; 

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            //flutuante com uma casa
            Console.WriteLine(valor.ToString("F1"));
            //valor monetário - currence
            Console.WriteLine(valor.ToString("C"));
            //percentual
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            CultureInfo culturaEUA = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));
            //Console.WriteLine(valor.ToString("C0", culturaEUA));
            int inteiro = 256;
            //insere zeros à direita completando o valor informado 256 e 7 zeros
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}

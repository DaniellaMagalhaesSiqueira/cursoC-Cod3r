using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quabrado = inteiro;
            double nota = 9.7;
            int notaTruncada = (int) nota;

            string idade = "13";
            int idadeInteiro = int.Parse(idade);

            idadeInteiro = Convert.ToInt32(idade);

            Console.WriteLine("Digite um número: ");
            string palavra = Console.ReadLine();
            //int numero;
            int.TryParse(palavra, out int numero);
            Console.WriteLine("Resultado: {0}", numero);

            Console.WriteLine("Digite um outro número: ");
            //int numero;
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);


        }
    }
}

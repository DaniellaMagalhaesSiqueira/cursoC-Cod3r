using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class ExemploLambda {
        public static void Executar() {
            //Action só tem retorno void    NUNCA RETORNA NADA  
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda com C#\n");
                Console.WriteLine("Lambda é uma função anônima.");
            };

            algoNoConsole();


            Action<string> saudacao = (a) => Console.WriteLine($"Olá, {a}!");

            saudacao("Daniella");

            //tipo de retorno int
            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());
            //retorn string e recebe um int - return implicito
            //quando tem um único parâmetro não precisa de parenteses
            Func<int, string> conversoHexa = numero => numero.ToString("X");

            Console.WriteLine(conversoHexa(56));
            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(28, 10, 1980));
        }
    }
}

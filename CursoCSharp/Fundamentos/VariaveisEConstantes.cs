using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é " + area + 1000);
            //Tipos internos
            bool estaChovendo = true;
            byte idade = 45;
            //byte com sinal
            sbyte saldoDeGols = sbyte.MinValue;
            short salario = short.MaxValue;
            int menorValorInteiro = int.MinValue;
            //inteiro sem sinal
            uint populacaoBrasileira = 207_600_000;
            long menorValor = long.MinValue;
            float precoComputador = 1299.99F;

        }
    }
}

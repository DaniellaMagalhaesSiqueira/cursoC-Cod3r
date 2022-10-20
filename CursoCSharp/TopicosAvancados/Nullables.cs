using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    class Nullables {
        public static void Executar() {
            Nullable<int> num1 = null;

            int? num2 = null;

            if (num1.HasValue) {
                Console.WriteLine("Valor de num1 é :{0}", num1);
            } else {
                Console.WriteLine("A variável não possui valor");
            }

            //dá um valor padrão a valor
            int valor = num1 ?? 1000;

            Console.WriteLine(valor);

            bool? booleano = null;
            bool resultado = booleano.GetValueOrDefault();
            Console.WriteLine(resultado);

            try {
                int x = num1.Value;
                int y = num2.Value;
            }catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}

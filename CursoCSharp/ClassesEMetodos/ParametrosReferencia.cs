using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosReferencia {
        //passando referencia para a função
        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }
        //out é válido quando vc deseja retornar mais de um valor da função
        //vc passa uma variável e depois utiliza ela com o valor que veio da função além do próprio
        //retorno da função;
        /*~Ex... Tenho uma função que retorna uma lista de strings, mas quero também um valor inteiro de 
         * algum contador de dentro da função. Então passo o contador pelo out e além de receber uma lista
         * recebo também o int passado pelo out
       */
        public static void AlterarOut(out int numero) {
            numero = 0;
            numero = numero + 15;
        }
        public static void Executar() {
            int a = 3;
            //chamar também no método para ficar explicito
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b = 2;
            AlterarOut(out int b);
            Console.WriteLine(b);
        }
    }
}

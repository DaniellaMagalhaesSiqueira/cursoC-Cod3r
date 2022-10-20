using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesDicionario {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();
            //Aceita repetição no valor, mas não na chave
            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) {
                //pega o valor
                Console.WriteLine("2004: " + filmes[2004]); //chamando um valor que não existe dá erro de compilação
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }
            Console.WriteLine(filmes.ContainsValue("Amnésia"));
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"filme {filme2006}!");
            filmes.TryGetValue(2016, out string filme2016);
            Console.WriteLine($"filme {filme2016}!");

            foreach(var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }

            foreach(var valor in filmes.Values) {
                Console.WriteLine(valor);
            }
            //primeira forma de varrer os dois
            foreach(KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
            foreach(var filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {
        public static void Executar() {
            var fila = new Queue<string>();
            fila.Enqueue("Fulano");
            fila.Enqueue("Cicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano"); //aceita repetição
            Console.WriteLine(fila.Peek()); //pega o elemento que está na ponta da fila mas não elimina
            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);
            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));

        }
    }
}

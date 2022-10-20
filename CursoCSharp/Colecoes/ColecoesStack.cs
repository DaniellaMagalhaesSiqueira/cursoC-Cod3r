using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesStack {
        public static void Executar() {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);
            foreach(var item in pilha) {
                Console.WriteLine(item);
            }
            //Pop remove e mostra
            Console.WriteLine($"\nPop: {pilha.Pop()}");
            foreach(var item in pilha) {
                Console.WriteLine(item);
            }
            //Peek pega o próximo elemento e não remove
            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);
        }
    }
}

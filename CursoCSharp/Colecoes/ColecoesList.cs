using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    /*Ctrl + . => gera métodos da ide
     */
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto() {
        }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
        //gerado autimaticamente com ctrl + . e cursor em cima da classe
        public override bool Equals(object obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        //gerado autimaticamente com ctrl + . e cursor em cima da classe
        public override int GetHashCode() {
            return HashCode.Combine(Nome, Preco);
        }

        //public override bool Equals(object obj) {
        //    Produto outroProduto = (Produto)obj;
        //    bool mesmonome = Nome == outroProduto.Nome;
        //    bool mesmopreco = Preco == outroProduto.Preco;
        //    return mesmonome && mesmopreco;
        //}
        /*
         * GetHashCode utiliza o tamanho para filtrar a lista e depois usar o Equals
         * Pode usar o id se houver id único
         */
        //public override int GetHashCode() {
        //    return Nome.Length;
        //}
    }
    class ColecoesList {
        public static void Executar() {

            var livro = new Produto("Game oh Thrones", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>{
                new Produto("Camisa", 29.9),
                new Produto("8ª temp. Game of Thrones", 99.9),
                new Produto("Poster", 10)
        };

            carrinho.Add(livro);
            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count) ;
            carrinho.RemoveAt(3);
            foreach(var item in carrinho) {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
        }
    }
}

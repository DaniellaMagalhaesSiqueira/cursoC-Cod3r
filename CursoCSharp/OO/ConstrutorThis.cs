using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    public class Animal {
        public string Nome { get; set; }

        public Animal(string nome) {
            Nome = nome;
        }

    }


    public class Cachorro: Animal{
        public double Altura { get; set; }


        public Cachorro(string nome) : base(nome){
            Console.WriteLine($"Cachorro {nome} foi inicializado");
        }

        //chama o próprio construtor
        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
            Console.WriteLine($"Cahorro {nome} com {altura} foi inicializado");
        }

        public override string ToString() {
            return $"{Nome} tem {Altura}cm de altura";
        }

    }


    class ConstrutorThis {
        public static void Executar() {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);
            Console.WriteLine(spike);
            Console.WriteLine(max);
        }
    }
}

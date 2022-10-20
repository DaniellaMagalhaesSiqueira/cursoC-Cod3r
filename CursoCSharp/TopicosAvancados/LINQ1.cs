using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
        public class Aluno {
            public string Nome;
            public int Idade;
            public double Nota;
        }
    class LINQ1 { 

        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno() {Nome = "André", Idade = 21, Nota = 4.3},
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5},
                new Aluno() {Nome = "Jorge", Idade = 20, Nota = 8.5},
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7},
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.5},
                new Aluno() {Nome = "Márcio", Idade = 18, Nota = 6.8}
            };
            Console.WriteLine("############# APROVADOS #################");
            //gera a partir do Linq.Where outra lista que passa pela condição
            //var aprovados = alunos.Where(a => a.Nota >= 7.0).OrderBy(a => a.Nome);
            var aprovados = alunos.Where(a => a.Nota >= 7.0).OrderBy(a => -a.Nota);
            foreach(var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n############# CHAMADA ###################");
            //ordena pelo nome e pega apenas a string nome
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada) {
                Console.WriteLine(aluno);
            }
            Console.WriteLine("\n################## Maiores de 21 ##############");
            var maiores = alunos.Where(aluno => aluno.Idade > 21);
            foreach (var aluno in maiores) {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n############## APROVADOS POR IDADE ###############");
            var alunosAprovados = from aluno in alunos
                                  //seleciona apenas os aprovados
                                  where aluno.Nota >= 7.0
                                  //ordena por idade
                                  orderby aluno.Idade
                                  //seleciona só o nome
                                  select aluno.Nome;

            foreach (var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }
        }
    }
}

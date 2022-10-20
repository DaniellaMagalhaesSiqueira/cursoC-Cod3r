using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    class LINQ2 {
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

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            var pedro2 = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Pedro2"));
            Console.WriteLine(pedro.Nome + " - " + pedro.Nota);
            if(pedro2 == null) {
                Console.WriteLine("Aluno inexistente");
            }
            //Console.WriteLine(pedro2.Nome + " - " + pedro2.Nota);
            //pega o primeiro que encontrar
            var ana = alunos.First(a => a.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota + " - " + ana.Nome);
            var cicrano = alunos.FirstOrDefault(a => a.Nome.Equals("Cicrano"));
            if(cicrano == null) {
                Console.WriteLine("Aluno Inexistente");
            }

            var outraAna = alunos.LastOrDefault(a => a.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nome + "-" + outraAna.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach(var item in exemploSkip) {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(a => a.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(a => a.Nota);
            Console.WriteLine(menorNota);

            var soma = alunos.Sum(a=> a.Nota);
            Console.WriteLine(soma);
            var media = alunos.Average(a => a.Nota);
            Console.WriteLine(media); 
            var mediaAprovados = alunos.Where(a=> a.Nota >= 7).Average(a => a.Nota);
            Console.WriteLine(mediaAprovados);
        }
    }
}

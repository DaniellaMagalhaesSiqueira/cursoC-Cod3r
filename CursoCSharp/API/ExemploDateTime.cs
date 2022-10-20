using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API {
    class ExemploDateTime {
        public static void Executar() {
            //ano, mês e dia
            //var dateTime = new DateTime(2030, 2, 1);
            var dateTime = new DateTime(year: 2030, day: 1, month: 2);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);
            //sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);
            //Com hora
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minutos: " + diaAtual.Minute);

            var amanha = DateTime.Today.AddDays(1);
            Console.WriteLine($"Amanhã: {amanha}");
            var ontem = DateTime.Today.AddDays(-1);
            Console.WriteLine($"Ontem: {ontem}");

            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}

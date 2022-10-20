using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API {
    class ExemploTimeSpan {
        public static void Executar() {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine(intervalo);
            Console.WriteLine("Minutos: " + intervalo.Minutes);
            Console.WriteLine("Intervalo em Minutos: " + intervalo.TotalMinutes);

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);
            //resultado dessa operação é TimeSpan
            var tempo = chegada - largada;
            Console.WriteLine("Duração: " + tempo);
            Console.WriteLine("Tipo: " + tempo.GetType());
            //gera um novo timespan não mexe no original
            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(8)));
            Console.WriteLine(intervalo);

            Console.WriteLine("Com ToString: " + intervalo.ToString("g"));
            Console.WriteLine("Com ToString: " + intervalo.ToString("G"));
            Console.WriteLine("Com ToString: " + intervalo.ToString("c"));

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").TotalMilliseconds);
        }
    }
}

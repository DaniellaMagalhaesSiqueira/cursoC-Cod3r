using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    interface Ponto {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto {
        public int X;
        public int Y;
        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    }
    class ExemploStruct {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;
            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X = {0}, Y = {1}", coordenadaInicial.X, coordenadaInicial.Y);  

            var coordenadaFinal = new Coordenada(9, 1);
            coordenadaFinal.MoverNaDiagonal(10);
            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X = {0}, Y = {1}", coordenadaFinal.X, coordenadaFinal.Y);

        }
    }
}

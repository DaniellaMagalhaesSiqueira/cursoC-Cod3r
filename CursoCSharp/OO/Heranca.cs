using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int veloMax) {
            VelocidadeMaxima = veloMax;
        }

       
        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;
            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        //modificador virtual indica que esse método pode ser sobrescrito
        //protected != public virtual
        public virtual int Acelerar(){
            return AlterarVelocidade(5);
        }
        
        public int Frear(){
            return AlterarVelocidade(-5);
        }

}
    //dá erro se não tiver o construtor padrão
    public class Uno : Carro {

        //Construtor do Uno chama o construtor base, constrói o objeto no base e depois aqui
        public Uno() : base(200){
        }
    }

    public class Ferrari : Carro {
        public Ferrari(): base(350) {

        }

        public override int Acelerar() {
            return AlterarVelocidade(15);
        }
        //oculta o método da classe mãe
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
    }
    

    class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            //Console.WriteLine(carro1.Acelerar());
            //Console.WriteLine(carro1.Acelerar());
           Console.WriteLine(carro2.Acelerar());
           Console.WriteLine(carro2.Acelerar());
           //Console.WriteLine(carro2.AlterarVelocidade(800)); inacessível por ser protected
          
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine("Ferrari com o tipo carro...");
            //essa condição permite que atribua na mesma variável valores diferentes em momentos diferentes
            Carro carro3 = new Ferrari(); //polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine("Colocando o carro3 como Uno");
            carro3 = new Uno();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}

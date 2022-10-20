using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    class Abstract {
        //Não pode ser instanciada, é abstrata, está inacabada  
        public abstract class Celular {
            public abstract string Assistente();

            public string Tocar() {
                return "Trim... trim... trim";
            }
        }

        public class Samsung : Celular {
            public override string Assistente() {
                return "Olá, meu nome é Bixby!";
            }
        }

        public class IPhone : Celular {
            public override string Assistente() {
                return "Olá, meu nome é Siri!";
            }
        }
        public static void Executar() {
            var celulares = new List<Celular> {
                new IPhone(),
                new Samsung()
            };
            foreach(var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}

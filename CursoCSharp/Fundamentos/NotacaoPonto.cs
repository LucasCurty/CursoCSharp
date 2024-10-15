using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {
        public static  void Executar() {
            string nome = "Olá mundo".ToUpper();
            Console.WriteLine(nome);
            Console.WriteLine($"O {nome} tem {nome.Length} letras");

            string nullName = null;
            Console.WriteLine(nullName?.Length);
        }
    }
}

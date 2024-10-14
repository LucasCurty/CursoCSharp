using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Inferencia {
        public static void Executar() {
            // inferencia de tipo
            var nome = "Lucas";
            // nome = 123; mesmo apos a inferencia, nao é possivel mudar o tipo
            Console.WriteLine("Seu nome é " + nome);

            //int idade;
            var idade = 28;
            Console.WriteLine("Sua idade é " + idade);

            int a;
            a = 3;

            int b = 2;
            Console.WriteLine("Soma de a + b: " + (a + b));
        }
    }
}

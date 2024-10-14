using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public  static void Executar() {
            // area de circuferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.15; constantes nao podem ser mudada

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            int menorValor = int.MinValue; // Mais usado dos inteiros dos quais são: byte, sbyte e short
            Console.WriteLine("Menor valor é " + menorValor);

            int maiorValor = int.MaxValue;
            Console.WriteLine("Maior valor é " + maiorValor);

            uint populacao = 200_222_444;
            Console.WriteLine(populacao);

            float precoComputador = 1299.99f;
            Console.WriteLine("O preço do computador é: " + precoComputador); 
        }
    }
}

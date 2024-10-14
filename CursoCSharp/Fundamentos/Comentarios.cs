using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Comentarios {
        public static void Executar() {
            // Cuidado com os comentários desnecessários 
            Console.WriteLine("Código claro é sempre melhor!");

            /// <summary>
            ///     esse é um summary 
            /// </summary>
            Console.WriteLine("O C# tem o XML Coments");

            /*
             * Esse é um comentário 
             * de multiplas linhas
             * 
             */
        }
    }
}

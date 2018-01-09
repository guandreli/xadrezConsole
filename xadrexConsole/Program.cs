using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace xadrexConsole {
    class Program {
        static void Main(string[] args) {
            Tabuleiro tab = new Tabuleiro(8, 8);

            posicaoXadrez pos = new posicaoXadrez('c', 7);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            Console.ReadKey();
        }
    }
}

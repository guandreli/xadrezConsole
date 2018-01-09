using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrexConsole {
    class Program {
        static void Main(string[] args) {
            Posicao p = new Posicao(3, 4);
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}

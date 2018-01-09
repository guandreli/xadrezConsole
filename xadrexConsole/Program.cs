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

            try {
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(4, 2));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 6));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(4, 6));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(4, 4));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 2));


                Tela.imprimirTabuleiro(tab);
            }
            catch(tabuleiroException e) {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}

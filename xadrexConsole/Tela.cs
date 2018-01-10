using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace xadrexConsole {
    class Tela {

        public static void imprimirTabuleiro(Tabuleiro tab) {
            for (int i = 0; i < tab.linhas; i++) {
                Console.Write((tab.linhas - i) + "    ");
                for (int j = 0; j < tab.colunas; j++) {
                    if (tab.peca(i, j) == null) {
                        Console.Write("-  ");
                    }
                    else {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write("  ");
                    }
                }
                Console.WriteLine("\n");
            }
            char l = 'a';
            Console.Write("    ");
            for (int i = 0; i < tab.colunas; i++) {
                Console.Write(l + "  ");
                l++;
            }
        }

        public static PosicaoXadrez lerPosicaoXadrez() {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca) {
            if (peca.cor == Cor.Branca) {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}

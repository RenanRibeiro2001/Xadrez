using System;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    class Program
    {
        public static void Main(String[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(7, 5));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(5, 4));

                Tela.imprimirTabuleiro(tab);


            } catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
using System;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    class Program
    {
        public static void Main(String[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}
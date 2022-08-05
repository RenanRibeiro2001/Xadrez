namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        //construtor
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //valida se a peca existe
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        //Da acesso individual para uma peca
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        //Da acesso individual para uma peca
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        //Coloca a peca
        public void colocarPeca(Peca P, Posicao Pos)
        {
            pecas[Pos.linha, Pos.coluna] = P;
            P.Posicao = Pos;
        } 

        //Valida se a posicao e valida
        public bool posicaoValida(Posicao pos)
        {
            if(pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posicao invalida!");
            }
        }
    }
}

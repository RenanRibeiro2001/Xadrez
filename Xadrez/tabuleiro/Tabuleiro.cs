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
            if (existePeca(Pos))
            {
                throw new TabuleiroException("Ja existe uma peca nessa posicao");
            }
            pecas[Pos.linha, Pos.coluna] = P;
            P.Posicao = Pos;
        } 

        //retirar uma peca
        public Peca retirarPeca(Posicao pos)
        {
            if(peca(pos) == null)
            {
                return null;
            } else  {
                Peca aux = peca(pos);
                aux.Posicao = null;
                pecas[pos.linha, pos.coluna] = null;
                return aux;
            }
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
namespace tabuleiro
{
    internal abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            this.cor = cor;
            this.qtdMovimentos = 0;
            this.tab = tab;
        }   

        //aumentar ou diminuir o movimento das pecas
        public void incrementarQteMovimentos()
        {
            qtdMovimentos++;
        }

        public void decrementarQteMovimentos()
        {
            qtdMovimentos--;
        }

        //ver se existem movimentos possiveis para a peca
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for(int i = 0; i < tab.linhas; i++)
            {
                for(int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i,j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        //metodo abstract para definir nas classes das pecas especificas
        public abstract bool[,] movimentosPossiveis();
    
    }
}

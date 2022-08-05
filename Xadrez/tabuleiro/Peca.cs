namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int qtdMovimentos, Tabuleiro tab)
        {
            Posicao = posicao;
            this.cor = cor;
            this.qtdMovimentos = 0;
            this.tab = tab;
        }   
    }
}

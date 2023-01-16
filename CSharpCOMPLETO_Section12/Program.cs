using System;
using tabuleiro;
using xadrez;

namespace CSharpCOMPLETO_Section12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Posicao P;
                //P = new Posicao(3, 4);
                //Console.WriteLine("Posição: " + P);

                //Tabuleiro tab = new Tabuleiro(8, 8);
                //tab.colocarPeca(new Torre(tab, Cor.Preta), new(0, 0));
                //tab.colocarPeca(new Torre(tab, Cor.Preta), new(1, 3));
                //tab.colocarPeca(new Rei(tab, Cor.Preta), new(0, 2));

                //tab.colocarPeca(new Torre(tab, Cor.Branca), new(3, 5));

                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);



                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }



                

                //PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                //Console.WriteLine(pos);
                //Console.WriteLine(pos.toPosicao());



            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
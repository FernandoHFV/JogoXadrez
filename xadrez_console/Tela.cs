using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro (Tabuleiro tab) // O for percorre as linhas e as colunas, se não tiver peça: - se tiver: peça
        {
            for (int i = 0; i<tab.linhas;i++)
            {
                for(int j=0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    Console.Write(tab.peca(i,j)+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}

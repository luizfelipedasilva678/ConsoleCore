using Interface.IJogador;
using Entities.Jogador1;
using Entities.Jogador2;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IJogador jogador1 = new Jogador1("Maria");
            IJogador jogador2 = new Jogador2("Pedro");

            var jogo = new JogoFODA(jogador2, jogador1);
            jogo.IniciarJogo();
        }
    }
}

using System;
using Interface.IJogador;

namespace GameTOP
{
   class JogoFODA
    {
        private IJogador _jogador1;
        private IJogador _jogador2;

        public JogoFODA(IJogador jogador1)
        {
            _jogador1 = jogador1;
        }

        public JogoFODA(IJogador jogador1, IJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }

        public void IniciarJogo()
        {
            Console.WriteLine(_jogador1.Chuta());
            Console.WriteLine(_jogador1.Corre());
            Console.WriteLine(_jogador1.Passa());

            System.Console.WriteLine("-----------------");
            
            Console.WriteLine(_jogador2.Chuta());
            Console.WriteLine(_jogador2.Corre());
            Console.WriteLine(_jogador2.Passa());
        }
    }
}
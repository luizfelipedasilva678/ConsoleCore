using Interface.IJogador;

namespace Entities.Jogador2
{
    public class Jogador2 : IJogador
    {   
        public string Name { get; set; }

        public Jogador2(string name)
        {
            Name = name;
        }

        public string Chuta()
        {
            return  $"{Name} está chutando";
        }

        public string Passa()
        {
            return $"{Name} está passando";
        }

        public string Corre(){
            return $"{Name} está correndo";
        }
    }
}
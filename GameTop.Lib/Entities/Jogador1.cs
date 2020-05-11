using Interface.IJogador;

namespace Entities.Jogador1
{
    public class Jogador1 : IJogador
    {
        public string Name { get; private set; }
        public Jogador1(string name)
        {
            Name = name;
        }

        public string Chuta()
        {
            return  $"{Name} está Chutando";
        }

        public string Corre()
        {
           return $"{Name} está Correndo";
        }

        public string Passa()
        {
            return $"{Name} está Passando";
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
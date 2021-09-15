using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Luciano Chuta \n";
        }

        public string Corre()
        {
            return "Luciano Corre \n";
        }

        public string Passe()
        {
            return "Luciano Passa \n";
        }
    }
}
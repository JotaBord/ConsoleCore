using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona está Chutando \n";
        }

        public string Corre()
        {
            return "Maradona está Correndo \n";
        }

        public string Passe()
        {
            return "Maradona está Passando \n";
        }
    }
}
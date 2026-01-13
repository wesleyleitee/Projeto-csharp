namespace FactoryPattern.Games
{
    public class XadrezGame : IGame
    {
        public string Tipo => "Xadrez";

        public void Start()
        {
            Console.WriteLine("Iniciando jogo de Xadrez.");
        }
    }
}

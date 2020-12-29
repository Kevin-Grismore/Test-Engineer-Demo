using Framework.Models;

namespace Framework.Services
{
    public class InMemoryGameService : IGameService
    {
        public Game GetGameByName(string gameName)
        {
            switch(gameName)
            {
                case "Uncharted":
                    return new UnchartedGame();

                case "Uncharted 2":
                    return new Uncharted2Game();
                
                default:
                    throw new System.ArgumentException("Game is not available:" + gameName);
            }
        }
    }
}
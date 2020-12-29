using Framework.Models;

namespace Framework.Services
{
    public interface IGameService
    {
        Game GetGameByName(string name);
    }
}
using System;
using Framework.Selenium;

namespace Games.Pages
{
    public class AllPages
    {
        [ThreadStatic]
        public static GamesPage Games;

        [ThreadStatic]
        public static GameDetailsPage GameDetails;

        public static void Init()
        {
            Games = new GamesPage(Driver.Current);
            GameDetails = new GameDetailsPage(Driver.Current);
        }
    }

}
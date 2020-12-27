using NUnit.Framework;
using RazorPagesGame.Models;
using System;

namespace Games.Tests
{
    public class GameTests
    {
        [SetUp]
        public void Setup()
        {

        }

        static Game[] games = {
            new Game {
            ID = 1,
            Title = "Uncharted",
            ReleaseDate = new DateTime(2007, 11, 19),
            Genre = "action-adventure",
            Price = 59.99M
            }
        };
        /*
        *   1. Given a Game is created
        *   2. When the game object has valid data
        *   3. Then the data in the object matches the input
        */
        [Test]
        [TestCaseSource("games")]
        public void VerifyGameID(Game game)
        {
            Assert.That(game.ID, Is.EqualTo(1));
        }

        [Test]
        [TestCaseSource("games")]
        public void VerifyGameTitle(Game game)
        {
            Assert.That(game.Title, Is.EqualTo("Uncharted"));
        }

        [Test]
        [TestCaseSource("games")]
        public void VerifyGameReleaseDate(Game game)
        {
            Assert.That(game.ReleaseDate, Is.EqualTo(new DateTime(2007, 11, 19)));
        }

        [Test]
        [TestCaseSource("games")]
        public void VerifyGameGenre(Game game)
        {
            Assert.That(game.Genre, Is.EqualTo("action-adventure"));
        }

        [Test]
        [TestCaseSource("games")]
        public void VerifyGamePrice(Game game)
        {
            Assert.That(game.Price, Is.EqualTo(59.99));
        }
    }
}
using NUnit.Framework;
using RazorPagesGame.Models;
using System;

namespace Games.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /*
        *   1. Given a Game is created
        *   2. When the game object has valid data
        *   3. Then the data in the object matches the input
        */
        [Test]
        public void CreateGame_WithCorrectData()
        {
            Game uncharted = new Game {
                ID = 1,
                Title = "Uncharted",
                ReleaseDate = new DateTime(2007, 11, 19),
                Genre = "action",
                Price = 59.99
            };


            Assert.That(uncharted.ID, Is.EqualTo(1));
            Assert.That(uncharted.Title, Is.EqualTo("Uncharted"));
            Assert.That(uncharted.ReleaseDate, Is.EqualTo(new DateTime(2007, 11, 19)));
            Assert.That(uncharted.Genre, Is.EqualTo("action-adventure"));
            Assert.That(uncharted.Price, Is.EqualTo(59.99));
        }
    }
}
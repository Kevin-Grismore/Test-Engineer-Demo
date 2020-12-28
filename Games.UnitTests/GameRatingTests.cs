using NUnit.Framework;
using RazorPagesGame.Models;
using System;

namespace Games.UnitTests
{
    [TestFixture]
    public class GameRatingTests
    {
        [TestCase(0)]
        [TestCase(99)]
        public void AnyAge_CanPlayEarlyChildhood(int age)
        {
            var game = new Game
            {
                Rating = "EC"
            };

            Assert.That(game.CanBePlayedAtAge(age), Is.EqualTo(true));
        }

        [TestCase(0)]
        [TestCase(99)]
        public void AnyAge_CanPlayEveryone(int age)
        {
            var game = new Game
            {
                Rating = "E"
            };

            Assert.That(game.CanBePlayedAtAge(age), Is.EqualTo(true));
        }

        [TestCase(0)]
        [TestCase(9)]
        public void BelowTen_CanNotPlayEveryone10Plus(int age)
        {
            var game = new Game
            {
                Rating = "E10+"
            };

            Assert.That(game.CanBePlayedAtAge(age), Is.EqualTo(false));
        }

        [TestCase(10)]
        [TestCase(99)]
        public void TenOrOlder_CanPlayEveryone10Plus(int age)
        {
            var game = new Game
            {
                Rating = "E10+"
            };

            Assert.That(game.CanBePlayedAtAge(age), Is.EqualTo(true));
        }

        [TestCase(0)]
        [TestCase(12)]
        public void BelowThirteen_CanNotPlayTeen(int age)
        {
            var game = new Game
            {
                Rating = "T"
            };

            Assert.That(game.CanBePlayedAtAge(age), Is.EqualTo(false));
        }

        [TestCase(13)]
        [TestCase(99)]
        public void ThirteenOrOlder_CanPlayTeen(int age)
        {
            var game = new Game
            {
                Rating = "T"
            };

            Assert.That(game.CanBePlayedAtAge(age), Is.EqualTo(true));
        }

        [TestCase(0)]
        [TestCase(16)]
        public void BelowSeventeen_CanNotPlayMature(int age)
        {
            var game = new Game
            {
                Rating = "M"
            };

            Assert.That(game.CanBePlayedAtAge(age), Is.EqualTo(false));
        }

        [TestCase(17)]
        [TestCase(99)]
        public void SeventeenOrOlder_CanPlayMature(int age)
        {
            var game = new Game
            {
                Rating = "M"
            };

            Assert.That(game.CanBePlayedAtAge(age), Is.EqualTo(true));
        }

        [TestCase(0)]
        [TestCase(17)]
        public void BelowEighteen_CanNotPlayAdult(int age)
        {
            var game = new Game
            {
                Rating = "A"
            };

            Assert.That(game.CanBePlayedAtAge(age), Is.EqualTo(false));
        }

        [TestCase(18)]
        [TestCase(99)]
        public void EighteenOrOlder_CanPlayAdult(int age)
        {
            var game = new Game
            {
                Rating = "A"
            };

            Assert.That(game.CanBePlayedAtAge(age), Is.EqualTo(true));
        }
    }
}
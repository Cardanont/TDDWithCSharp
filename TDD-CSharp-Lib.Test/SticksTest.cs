using CSharpTDD.Sticks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_CSharp_Lib.Test
{
    [TestFixture]
    class SticksTests
    {

        [Test]
        public void Ctor_LessThan10Sticks_Throws()
        {
            Assert.Throws<ArgumentException>(() => new SticksGame(9, Player.Machine));
        }

        [Test]
        public void Ctor_ValidParams_GameIsInCorrectState()
        {
            int sticks = 10;
            Player player = Player.Machine;

            var sut = new SticksGame(sticks, player);

            Assert.That(sut.NumberOfSticks, Is.EqualTo(sticks));
            Assert.That(sut.Turn, Is.EqualTo(player));
        }

        // Just for the records hehe
        [Test]
        [TestCase(0)]
        [TestCase(4)]
        public void HumanMakesMove_InvalidNumbersOfSticks_Throws(int take)
        {
            var sut = new SticksGame(10, Player.Human);
            Assert.Throws<ArgumentException>(() => sut.HumaMakesMove(take));
        }


        [Test]
        [TestCase(1, 9)]
        [TestCase(2, 8)]
        [TestCase(3, 7)]

        public void HumanMakesMove_CorrectGameState(int takes, int remains)
        {
            var sut = new Game(10, Player.Human);
            sut = sut.HumanMakesMove(takes);

            Assert.That(sut.NumberOfSticks, Is.EqualTo(remains));
            Assert.That(sut.Turn, Is.EqualTo(Player.Machine));
        }

    }
}

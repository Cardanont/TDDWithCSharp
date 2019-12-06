﻿using CSharpTDD.Sticks;
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

    }
}

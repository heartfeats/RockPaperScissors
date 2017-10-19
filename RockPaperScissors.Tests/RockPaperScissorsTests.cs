using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests {

    [TestClass]
    public class RockPaperScissorsTests {
        [TestMethod]
        public void PlayerOneWins () {
            // Arrange
            PlayerChoices newPlayerChoices = new PlayerChoices ("rock", "scissors");

            var output = "Player One Wins!";

            // Act
            string result = newPlayerChoices.ComparePlayerChoices ();

            // Assert
            Assert.AreEqual (result, output);
        }
    }
}
using PullYourLuck.Controllers;
using PullYourLuck.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ScoreTests
    {
        [Fact]
        public void TestCalculateScore() {
            GameBoard game = new GameBoard();
            ScoreController score = new ScoreController();
            Card card1 = new Card(1, "circle");
            Card card2 = new Card(2, "circle");
            Card card3 = new Card(3, "circle");

            game.AddPlayedCard(card1);
            game.AddPlayedCard(card2);
            game.AddPlayedCard(card3);

            game.CalculateScore();
            Assert.Equal(6, game.currentScore);


        }
    }
}

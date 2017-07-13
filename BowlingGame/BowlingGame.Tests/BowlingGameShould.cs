using System.Runtime.InteropServices;
using NUnit.Framework;

namespace BowlingGame.Tests
{
    [TestFixture]
    public class BowlingGameShould
    {
        [TestCase("--|--|--|--|--|--|--|--|--|--||", 0)]
        [TestCase("1-|--|--|--|--|--|--|--|--|--||", 1)]
        [TestCase("2-|--|--|--|--|--|--|--|--|--||", 2)]
        [TestCase("3-|--|--|--|--|--|--|--|--|--||", 3)]
        public void CalculateScoreForFirstPinHit(string game, int expectedScore)
        {
            var bowlingGameScore = new Score();

            var score = bowlingGameScore.Calculate(game);

            Assert.AreEqual(expectedScore, score);
        }

        [TestCase("-1|--|--|--|--|--|--|--|--|--||", 1)]
        [TestCase("-2|--|--|--|--|--|--|--|--|--||", 2)]
        [TestCase("-3|--|--|--|--|--|--|--|--|--||", 3)]
        [TestCase("23|--|--|--|--|--|--|--|--|--||", 5)]
        [TestCase("54|--|--|--|--|--|--|--|--|--||", 9)]
        public void CalculateScoreForFirstNonStrikeOrSpareGame(string game, int expectedScore)
        {
            var bowlingGameScore = new Score();

            var score = bowlingGameScore.Calculate(game);

            Assert.AreEqual(expectedScore, score);
        }

        [TestCase("-/|--|--|--|--|--|--|--|--|--||", 10)]
        [TestCase("1/|--|--|--|--|--|--|--|--|--||", 10)]
        [TestCase("2/|--|--|--|--|--|--|--|--|--||", 10)]
        [TestCase("2/|1-|--|--|--|--|--|--|--|--||", 12)]
        [TestCase("2/|13|--|--|--|--|--|--|--|--||", 15)]
        public void CalculateScoreForFirstSpareGame(string game, int expected)
        {
            var bowlingGameScore = new Score();

            var score = bowlingGameScore.Calculate(game);

            Assert.AreEqual(expected, score);
        }

        [TestCase("31|6-|--|--|--|--|--|--|--|--||", 10)]
        [TestCase("31|61|--|--|--|--|--|--|--|--||", 11)]
        [TestCase("-1|-1|--|--|--|--|--|--|--|--||", 2)]
    
        public void CalcuateScoreForFirstAndSecondGame(string game, int expected)
        {
            var bowlingGameScore = new Score();

            var score = bowlingGameScore.Calculate(game);

            Assert.AreEqual(expected, score);

        }
    }

    public class Score  
    {
        public int Calculate(string bowlingGame)
        {
            var listOfGames = bowlingGame.Split('|');

            string gameOne = listOfGames[0];
            string gameTwo = listOfGames[1];
            string gameThree = listOfGames[2];

            var firstGameScore = CalculateFrameScore(gameOne, gameTwo[0].ToString());
            var secondGameScore = CalculateFrameScore(gameTwo, gameThree[0].ToString());

            return firstGameScore + secondGameScore;
        }

        public int CalculateFrameScore(string game, string firstPinOfTheNextGame)
        {
            int firstPinOfTheNextGameScore;
            int.TryParse(firstPinOfTheNextGame, out firstPinOfTheNextGameScore);

            int firstPinScore;
            int.TryParse(game[0].ToString(), out firstPinScore);

            int secondPinScore;
            int.TryParse(game[1].ToString(), out secondPinScore);

            if (game[1].ToString() == "/")
            {
                return 10 + firstPinOfTheNextGameScore;
            }

            return firstPinScore + secondPinScore;
        }
    }
}

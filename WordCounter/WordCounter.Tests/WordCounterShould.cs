using NUnit.Framework;

namespace WordCounter.Tests
{
    [TestFixture]
    public class WordCounterShould
    {
        [Test]
        public void ReturnZeroWhenTheInputIsEmpty()
        {
            //Arrange
            var inputString = string.Empty;

            //Act
            var wordCounterer = new WordCounterer();
            int numberOfWords = wordCounterer.NumberOfWords(inputString);

            //Assert
            Assert.AreEqual(numberOfWords, 0);
        }

        [Test]
        public void ReturnOneWhenTheInputStringContainsTheWordMother()
        {
            //Arrange
            var inputString = "Mother";

            //Act
            var wordCounterer = new WordCounterer();
            int 

            //Assert
        }
    }
}

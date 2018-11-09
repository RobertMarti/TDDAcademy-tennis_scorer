namespace TddAcademy.Tests
{
    using FakeItEasy;
    using FluentAssertions;
    using Xunit;

    public class TennisScorerTest
    {
        //todo Spiel Start: Score = "love:love"
        //todo Score A: Score = "fifteen:love"
        //todo Score B: Score = "fifteen:fifteen"
        //todo Score A 3 mal: Score = "Winner A"

        private TennisScorer _testee;

        public TennisScorerTest()
        {
        }

        [Fact]
        public void WhenGameStartsScoreShouldBeLoveLove()
        {
            //Arrange
            _testee = new TennisScorer();

            //Act
            var score = _testee.Score;

            //Assert
            score.Should().Be("love:love");
        }
    }
}
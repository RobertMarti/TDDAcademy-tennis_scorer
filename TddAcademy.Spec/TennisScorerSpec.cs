using FluentAssertions;
using Xbehave;

namespace TddAcademy.Spec
{

    public class TennisScorerSpec
    {
        // todo: implement TennisScorer acceptance test first 

        private const string Love = "love";
        private const string Fifteen = "fifteen";
        private const string Thirty = "thirty";
        private const string Forty = "forty";


        private TennisScorer _tennisscorer;

        //[Background]
        //public void Background()
        //{
        //    _tennisscorer = new TennisScorer();
        //}

        [Scenario]
        public void PlayMatch()
        {
            "When Match starts"
                .x(() => _tennisscorer = new TennisScorer());

            $"Then result should be {Love}:{Love}"
                .x(() => _tennisscorer.Score.Should().Be($"{Love}:{Love}"));

            "When a Scores"
                .x(() => _tennisscorer.ScorePlayerA());

            $"Then result should be {Fifteen}:{Love}"
                .x(() => _tennisscorer.Score.Should().Be($"{Fifteen}:{Love}"));
        }

    }
}
namespace TddAcademy
{
    public class TennisScorer : ITennisScorer
    {
        private int _scoreA = 0;
        private int _scoreB = 0;
        private ScorePrinter _scorePrinter;

        public TennisScorer()
        {
            _scorePrinter = new ScorePrinter();
        }
        public void ScorePlayerA()
        {
            _scoreA++;
        }

        public void ScorePlayerB()
        {
            _scoreB++;
        }

        public string Score
        {
            get
            {
                return _scorePrinter.GetScoreOutput(_scoreA, _scoreB);
            }
        }
    }
}
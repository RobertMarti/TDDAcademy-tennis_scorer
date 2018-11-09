using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using TddAcademy;

namespace TddAcademy
{
    public class ScorePrinter
    {
        public string GetScoreOutput(int scoreA, int scoreB)
        {
            return $"{GetScoreOutput(scoreA)}:{GetScoreOutput(scoreB)}";
        }

        private string GetScoreOutput(int score)
        {
            switch (score)
            {
                case 0:
                    return "love";
                case 1:
                    return "fifteen";
                case 2:
                    return "thyrty";
                case 3:
                    return "forty";
                default:
                    return "invalid score";
            }

        }
    }
}

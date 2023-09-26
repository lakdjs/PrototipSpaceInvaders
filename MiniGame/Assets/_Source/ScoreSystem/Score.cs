using Unity.VisualScripting;
using UnityEngine;

namespace ScoreSystem
{
    public class Score
    {
        private int _scorePlayer;
        private ScoreView _scoreView;

        public Score(ScoreView scoreView)
        {
            _scoreView = scoreView;
        }
        public void ScoreGain()
        {
            ++_scorePlayer;
            _scoreView.ScoreViewUpdate(_scorePlayer);
        }
    }
}

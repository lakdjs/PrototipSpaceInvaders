using UnityEngine;

namespace ScoreSystem
{
    public class Score 
    {
        public int ScorePlayer { get; private set; }
        
        public void ScoreGain()
        {
            ScorePlayer += 1;
        }
    }
}

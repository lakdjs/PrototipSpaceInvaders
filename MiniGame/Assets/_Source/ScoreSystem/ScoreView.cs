using System;
using PlayerSystem;
using UnityEngine;
using TMPro;
using Unity.UI;
using UnityEngine.UI;

namespace ScoreSystem
{
    public class ScoreView : MonoBehaviour
    {
         [SerializeField] private TextMeshProUGUI text;
         public Score Score { get; private set; }

         private void Start()
         {
             Score = new Score();
         }

        private void Update()
        {
             text.text = $"score:{Score.ScorePlayer}";
        }
    }
}

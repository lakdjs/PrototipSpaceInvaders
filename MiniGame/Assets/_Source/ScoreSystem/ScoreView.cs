using System;
using PlayerSystem;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

namespace ScoreSystem
{
    public class ScoreView : MonoBehaviour
    {
         [SerializeField] private TextMeshProUGUI text;

         private void Start()
         {
             text.text = $"score:";
         }

         public void ScoreViewUpdate(int k)
        {
             text.text = $"score:{k}";
        }
    }
}

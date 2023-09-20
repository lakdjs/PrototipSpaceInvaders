using System;
using UnityEngine;

namespace GameSystem
{
    public class Deadline : MonoBehaviour
    {
        [SerializeField] private Game game;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.layer == 3)
            {
                game.Lose();   
            }
        }
    }
}

using UnityEngine;

namespace BoarderSystem
{
    public class Boarder : MonoBehaviour
    {
        [SerializeField] private Transform[] boarders;
        [SerializeField] private float boarder1;
        [SerializeField] private float boarder2;

        private void Start()
        {
            boarders[0].position = new Vector3(boarder1, 0f, 0f);
            boarders[1].position = new Vector3(boarder2, 0f, 0f);
        }
    }
}

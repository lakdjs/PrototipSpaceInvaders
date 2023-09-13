using UnityEngine;

namespace EnemySystem
{
    public class Enemy : MonoBehaviour
    {
        [field: SerializeField] public float HealthEnemy { get; private set; }
        [field: SerializeField] public float MovementSpeedEnemy { get; private set; }
    }
}

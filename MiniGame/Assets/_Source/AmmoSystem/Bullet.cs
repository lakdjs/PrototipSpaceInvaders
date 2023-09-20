using System;
using ScoreSystem;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace AmmoSystem
{
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float destroyTime;
        [SerializeField] private LayerMask layerMask;
        private Rigidbody _rb;
        private ScoreView _scoreView;
        
        private void Start()
        {
            _scoreView = FindObjectOfType<ScoreView>();
            _rb = GetComponent<Rigidbody>();
            _rb.useGravity = false;
            Destroy(gameObject, destroyTime);
        }
        private void Update()
        {
            Fly();
        }

        void Fly()
        {
            _rb.velocity = transform.up * speed;
        }
        
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.layer == 3)
            {
                _scoreView.Score.ScoreGain();
                Destroy(gameObject);
            }
        }
    }
}

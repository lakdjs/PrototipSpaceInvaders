using System;
using JetBrains.Annotations;
using ScoreSystem;
using UnityEngine;
using UnityEngine.UIElements;

namespace AmmoSystem
{
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float destroyTime;
        [SerializeField] private LayerMask layerMask; 
        private Rigidbody _rb;
        
        
        private void Start()
        {
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
                Destroy(gameObject);
            }
        }
    }
}

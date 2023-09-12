using PlayerSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private Player _player;
        private PlayerInvoker _playerInvoker;
        private const string Horizontal = "Horizontal";
        private void Awake()
        {
            _playerInvoker = new PlayerInvoker(_player);
        }
        private void Update()
        {
                ReadMove();
                //ReadShoot();
        }

        private void ReadShoot()
        {
            throw new System.NotImplementedException();
        }

        private void ReadMove()
        {
            float horizontal = Input.GetAxisRaw(Horizontal);
            Vector3 moveDirection = new Vector3(horizontal, 0f, 0f );
            _playerInvoker.Move(moveDirection);
        }
    }
}

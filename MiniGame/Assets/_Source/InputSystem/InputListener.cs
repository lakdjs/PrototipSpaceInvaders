using GameSystem;
using PlayerSystem;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private Player player;
        [SerializeField] private KeyCode codeRestart;
        [SerializeField] private Game game;
        private PlayerInvoker _playerInvoker;
        private const string Horizontal = "Horizontal";
        private void Awake()
        {
            _playerInvoker = new PlayerInvoker(player);
        }
        private void Update()
        {
            ReadMove();
            ReadShoot();
            ReadRestart();
        }

        private void ReadShoot()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _playerInvoker.Shoot();
            }
        }

        private void ReadMove()
        {
             float horizontal = Input.GetAxisRaw(Horizontal);
             Vector3 moveDirection = new Vector3(horizontal, 0f, 0f );
             _playerInvoker.Move(moveDirection);
        }

        private void ReadRestart()
        {
            if (Input.GetKeyDown(codeRestart))
            {
                game.Restart();
            }
        }
    }
}

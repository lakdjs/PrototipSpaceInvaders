using UnityEngine;

namespace PlayerSystem
{
    public class PlayerInvoker 
    {
        private PlayerMovement _playerMovement;
        private Player _player;
        public PlayerInvoker(Player player)
        {
            _player = player;
            _playerMovement = new PlayerMovement();
        }
        public void Move(Vector3 moveDirection)
        {
            _playerMovement.Move(_player.Rb,_player.MovementSpeed,moveDirection);
        }
    }
}

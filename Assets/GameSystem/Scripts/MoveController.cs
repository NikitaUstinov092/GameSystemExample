using GameSystem.Scripts.GameSystem;
using UnityEngine;
using UnityEngine.Serialization;

namespace GameSystem.Scripts
{
    public sealed class MoveController : MonoBehaviour, 
        IGameStartListener,
        IGameFinishListener
    {
        [SerializeField]
        private Player _player;

        [SerializeField]
        private KeyboardInput _input;
        
        void IGameStartListener.OnStartGame()
        {
            _input.OnMove += OnMove;
        }

        void IGameFinishListener.OnFinishGame()
        {
            _input.OnMove -= OnMove;
        }

        private void OnMove(Vector2 direction)
        {
            var offset = new Vector3(direction.x, 0, direction.y) * Time.deltaTime;
            _player.Move(offset);
        }
    }
}
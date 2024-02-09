using System;
using GameSystem.Scripts.GameSystem;
using UnityEngine;

namespace GameSystem.Scripts
{
    public sealed class KeyboardInput : MonoBehaviour, IGameUpdateListener
    {
        public Action<Vector2> OnMove;
        
        void IGameUpdateListener.OnUpdate(float deltaTime)
        {
            HandleKeyboard();
        }

        private void HandleKeyboard()
        {
            
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Move(Vector2.up);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                Move(Vector2.down);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                Move(Vector2.left);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                Move(Vector2.right);
            }
        }

        private void Move(Vector2 direction)
        {
            OnMove?.Invoke(direction);
        }
    }
}
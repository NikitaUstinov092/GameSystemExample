using UnityEngine;

namespace GameSystem.Scripts.GameSystem
{
   
    [RequireComponent(typeof(GameManager))]
    public sealed class GameManagerInstaller : MonoBehaviour 
    {
        private void Awake() 
        {
            var gameManager = GetComponent<GameManager>();
            var listeners = GetComponentsInChildren<IGameListener>();
            Debug.Log(listeners.Length);
            
            foreach (var listener in listeners)
            {
                gameManager.AddListener(listener);
            }
        }
    }
}
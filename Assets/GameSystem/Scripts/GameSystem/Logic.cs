using GameSystem.Scripts.GameSystem;
using UnityEngine;

public class Logic : MonoBehaviour, IGameStartListener
{
    // Start is called before the first frame update
    
    void IGameStartListener.OnStartGame()
    {
        Debug.Log("Start");
    }
}

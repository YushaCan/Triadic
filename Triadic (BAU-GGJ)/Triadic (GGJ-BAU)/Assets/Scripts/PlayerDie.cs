using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerDie : MonoBehaviour
{
    public UIFunctions LevelLoader;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
        {
            if (!UnitePlayers.areGrays)
            {
                LevelLoader.Restart();
            }          
        }
    }
}

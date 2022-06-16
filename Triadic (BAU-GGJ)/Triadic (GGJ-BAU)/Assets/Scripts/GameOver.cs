using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private bool player1Finish;
    private bool player2Finish;
    private float time;
    private Animator playerAnimator;

    public static bool isGameOver;
    private void Start()
    {
        isGameOver = false;
        time = 0.33f;
        player1Finish = false;
        player2Finish = false;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
        {
            if (collision.gameObject.CompareTag("Player1"))
            {
                player1Finish = true;
            }
            if (collision.gameObject.CompareTag("Player2"))
            {
                player2Finish = true;
            }
            playerAnimator = collision.gameObject.GetComponent<Animator>();
            playerAnimator.SetTrigger("Finish");
            StartCoroutine(DeletePlayer(collision.gameObject));
            if (player1Finish && player2Finish)
            {
                isGameOver = true;
            }
        } 
    }

    public IEnumerator DeletePlayer(GameObject player)
    {
        yield return new WaitForSeconds(time);
        player.gameObject.SetActive(false);
    }
}

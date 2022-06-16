using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitePlayers : MonoBehaviour
{
    private SpriteRenderer player1SR;
    public Animator player2Animator;
    private Animator player1Animator;
    public static bool areGrays;
    // Start is called before the first frame update
    void Start()
    {
        areGrays = false;
        player1Animator = GetComponent<Animator>();
        player1SR = GetComponent<SpriteRenderer>();
    }

    // For Player's color to turn gray when they collide
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player2"))
        {
            areGrays = true;
            player1Animator.SetBool("Gray", true);
            player2Animator.SetBool("Gray", true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player2"))
        {
            areGrays = false;
            player1Animator.SetBool("Gray", false);
            player2Animator.SetBool("Gray", false);
        }
    }
}

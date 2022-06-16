using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Button : MonoBehaviour
{
    public Animator buttonAnimator;

    public static bool moving;

    private void Start()
    {
        moving = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
        {
            buttonAnimator.SetBool("isTouched", true);
            moving = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        buttonAnimator.SetBool("isTouched", false);
        moving = false;
    }
}

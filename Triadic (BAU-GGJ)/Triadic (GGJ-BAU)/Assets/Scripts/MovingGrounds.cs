using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingGrounds : MonoBehaviour
{
    public Vector2 endPoint;
    public Vector2 startPoint;
    public int groundMoveTime;

    // Update is called once per frame
    void Update()
    {
        if (Button.moving)
        {
            gameObject.transform.DOMove(endPoint, groundMoveTime);
        }
        else
        {
            gameObject.transform.DOMove(startPoint, groundMoveTime);
        }
    }
}

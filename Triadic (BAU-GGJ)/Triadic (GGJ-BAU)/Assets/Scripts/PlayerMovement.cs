using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public float stop;
    public float jumpForce;

    private bool isGrounded;

    private Rigidbody2D player1RB;
    private Rigidbody2D player2RB;

    public GameObject leftTrail;
    public GameObject rightTrail;

    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    // Start is called before the first frame update
    void Start()
    {
        if (this.CompareTag("Player1"))
        {
            player1RB = GetComponent<Rigidbody2D>();
        }
        else if(this.CompareTag("Player2"))
        {
            player2RB = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.CompareTag("Player1"))
        {
            MovePlayer1();
        }
        else if (this.CompareTag("Player2"))
        {
            MovePlayer2();
        }
    }
    void MovePlayer1()
    {
        // For checking wheter the player is on ground or not
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);

        // For moving left
        if (Input.GetKey(KeyCode.A))
        {
            player1RB.velocity = new Vector2(-moveSpeed, player1RB.velocity.y);
            rightTrail.gameObject.SetActive(true);
            leftTrail.gameObject.SetActive(false);
            if (Input.GetKeyDown(KeyCode.W) && isGrounded)
            {
                player1RB.velocity = new Vector2(player1RB.velocity.x, jumpForce);
                isGrounded = false;
            }
        }
        // For moving right
        else if (Input.GetKey(KeyCode.D))
        {
            player1RB.velocity = new Vector2(moveSpeed, player1RB.velocity.y);
            leftTrail.gameObject.SetActive(true);
            rightTrail.gameObject.SetActive(false);
            if (Input.GetKeyDown(KeyCode.W) && isGrounded)
            {
                player1RB.velocity = new Vector2(player1RB.velocity.x, jumpForce);
                isGrounded = false;
            }
        }
        // For jump
        else if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            player1RB.velocity = new Vector2(player1RB.velocity.x, jumpForce);
            isGrounded = false;
        }
        // When player has stopped
        else
        {
            player1RB.velocity = new Vector2(stop, player1RB.velocity.y);
        }
    }
    void MovePlayer2()
    {
        // For checking wheter the player is on ground or not
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);

        // For moving left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player2RB.velocity = new Vector2(-moveSpeed, player2RB.velocity.y);
            rightTrail.gameObject.SetActive(true);
            leftTrail.gameObject.SetActive(false);
            if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
            {
                player2RB.velocity = new Vector2(player2RB.velocity.x, jumpForce);
                isGrounded = false;
            }
        }
        // For moving right
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            player2RB.velocity = new Vector2(moveSpeed, player2RB.velocity.y);
            leftTrail.gameObject.SetActive(true);
            rightTrail.gameObject.SetActive(false);
            if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
            {
                player2RB.velocity = new Vector2(player2RB.velocity.x, jumpForce);
                isGrounded = false;
            }
        }
        // For jump
        else if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            player2RB.velocity = new Vector2(player2RB.velocity.x, jumpForce);
            isGrounded = false;
        }
        // When player has stopped
        else
        {
            player2RB.velocity = new Vector2(stop, player2RB.velocity.y);
        }
    }
}

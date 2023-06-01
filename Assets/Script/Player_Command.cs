using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Command : MonoBehaviour
{
    public float moveSpeed = 5f; // vitesse de déplacement
    public float jumpForce = 10f; // force de saut
    public Transform groundCheck; // objet qui vérifie si le joueur touche le sol
    public LayerMask groundLayer; // couche du sol

    public Transform AccrocheCheck;
    public LayerMask AccrrocheLayer; 

    public float moveInput;
    public bool flip;
    private Rigidbody2D rb;
    private bool isGrounded = false;
    [SerializeField] private float gravity;
    [SerializeField] private SpriteRenderer sr;

    Animator Anim;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = gravity;
        flip = true;
        Anim = GetComponent<Animator>();

    }

    void Update()
    {
        // vérifie si le joueur touche le sol
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        // déplacement horizontal
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        if (rb.velocity.y < 0)
        {
            Anim.SetBool("Fall", true);
        } 
        else
        {
            Anim.SetBool("Fall", false);
        }

        if (moveInput != 0)
        {
            Anim.SetBool("Walk", true);
        } else
        {
            Anim.SetBool("Walk", false);
        }

        // Turn
        if (moveInput != 0)
        {
            if (moveInput > 0)
            {
                flip = true;
                sr.flipX = false;
                transform.localScale = new Vector2(3.7f, 3.7f); // tourne le personnage à droite
            }
            else
            {
                flip = false;
                sr.flipX = true;
                transform.localScale = new Vector2(-3.7f, 3.7f); // tourne le personnage à gauche
            }
        }




        // saut

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && isGrounded)
        {
            Anim.SetTrigger("Jump");
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Anim.SetTrigger("Jump");
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}

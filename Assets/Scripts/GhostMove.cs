using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMove : MonoBehaviour
{
    [Header("FUERZAS")]
    private Rigidbody2D rb;
    public float jumpForce;

    [Header("MOVIMIENTO")]
    [SerializeField] float playerSpeed;

    [Header("FLIP")]
    public bool isFacingRight = true;

    [Header("RAYCAST")]
    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); 
        rb.linearVelocity = new Vector2((horizontalInput * playerSpeed), rb.linearVelocity.y);

        //FLIP 
        if (horizontalInput > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (horizontalInput < 0 && isFacingRight)
        {
            Flip();
        }

    }

    void Update()
    {
        //RAYCAST 
        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);


        //SALTO 
        if (Input.GetKeyUp(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * 10 * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }
    private void Flip()
    {
        isFacingRight = !isFacingRight; // Cambia el estado de la dirección
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f; // Invierte el eje X
        transform.localScale = localScale;


    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {


        if(collision2D.gameObject.CompareTag("enemy"))
        {
            Debug.Log("GameOver");
        }
    }
}

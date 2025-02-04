using UnityEngine;

public class RPG_Move_v2 : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Vector2 lastDirection = Vector2.down; // Dirección inicial mirando hacia abajo
    public Animator anim;
    SpriteRenderer sp;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);

        if (movement.x < 0)
        {
            sp.flipX = true;
        }

        if (movement.x > 0)
        {
            sp.flipX = false;
        }

        // Si el personaje se mueve, actualizamos la última dirección
        if (movement != Vector2.zero)
        {
            lastDirection = movement;
        }

        if (anim != null)
        {
            anim.SetFloat("HorizontalIdle", lastDirection.x);
            anim.SetFloat("VerticalIdle", lastDirection.y);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}

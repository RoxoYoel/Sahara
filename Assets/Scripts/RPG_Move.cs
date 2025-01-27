using UnityEngine;

public class RPG_Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody2D rb;
    Vector2 movement;
    Animator anim;
    SpriteRenderer sp;

    private void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        if (movement.x < 0)
        {
            sp.flipX = true;
        }
        else
        {
            sp .flipX = false;
        }

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude); 
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement *moveSpeed);
    }
}

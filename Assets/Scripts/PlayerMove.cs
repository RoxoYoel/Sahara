using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Fuerzas
    private Rigidbody2D rb;
    public float jumpForce;
    public float speed;

    //Animaciones
    [SerializeField] Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
            anim.SetTrigger("RunRight");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
            anim.SetTrigger("RunBack");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
            anim.SetTrigger("RunForward");
        }

    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {

    }
}

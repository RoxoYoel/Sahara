using UnityEngine;

public class photoShoot : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void CameraShoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("Photo", true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("Photo", false);
        }
    }

    void Update()
    {
        CameraShoot();
    }
}

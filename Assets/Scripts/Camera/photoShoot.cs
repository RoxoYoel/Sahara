using UnityEngine;
using System.Collections;


public class photoShoot : MonoBehaviour
{
    public Animator anim;
    public GameManager GameManager;
    public AudioSource audioSource;
    public GameObject opciones;
    void Start()
    {
        anim = GetComponent<Animator>();
        opciones.SetActive(false);
    }
    public void CameraShoot()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.Photo == true)
        {
            anim.SetBool("Photo", true);
            audioSource.Play();
            StartCoroutine(AparecerBotonesDespuesDeTiempo(2f));

        }
        if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("Photo", false);
        }
    }
    IEnumerator AparecerBotonesDespuesDeTiempo(float segundos)
    {
        yield return new WaitForSeconds(segundos); 
        Time.timeScale = 0;
        opciones.SetActive(true);
    }

        void Update()
    {
        CameraShoot();
    }
}

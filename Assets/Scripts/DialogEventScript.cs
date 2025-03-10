using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class DialogEventScript : MonoBehaviour
{
    public RPG_Move_v2 script;
    public TMP_Text tmpText;
    public TMP_Text tmpName;
    public AudioSource CocheCerrado;
    public GameObject closeCar;
    public GameObject openCar;
    public Animator cocheAnim;
    public AudioSource cocheArrancando;
    public GameObject finDemo;

    public void FinDemo()
    {
        StartCoroutine(FinDemo(5f));
    }

    IEnumerator FinDemo(float segundos)
    {
        yield return new WaitForSeconds(segundos);
        finDemo.SetActive(true);
    }
    public void CargarEscena()
    {
        StartCoroutine(CargarEscena(12f));
    }

    IEnumerator CargarEscena(float segundos)
    {
        yield return new WaitForSeconds(segundos);
        SceneManager.LoadScene(0);
    }


    public void CochePirando()
    {
        StartCoroutine(CochePirando(2.5f));
    }
    IEnumerator CochePirando(float segundos)
    {
        yield return new WaitForSeconds(segundos);
        cocheAnim.SetBool("Marchar", true);
    }

    public void CocheSonidoPirando()
    {
        StartCoroutine(CocheSonidoPirando(1.5f));
    }
    IEnumerator CocheSonidoPirando(float segundos)
    {
        yield return new WaitForSeconds(segundos);
        cocheArrancando.Play();
    }
    public void CerrarCoche()
    {
        StartCoroutine(SubirseAlCoche(1f));
    }

    IEnumerator SubirseAlCoche(float segundos)
    {
        yield return new WaitForSeconds(segundos);
        closeCar.SetActive(true);
        openCar.SetActive(false);
    }
    public void SonidoCerrarCoche()
    {
        StartCoroutine(SonidoCerrarCoche(0.85f));
    }

    IEnumerator SonidoCerrarCoche(float segundos)
    {
        yield return new WaitForSeconds(segundos);
        CocheCerrado.Play();
    }

    public void DialogEnter()
    {
        script.enabled = false;
    }
    public void DialogExit(GameObject dialog)
    {
        script.enabled = true;
        dialog.SetActive(false); 
    }

    public void ActivarObjeto(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void DesactivarObjeto(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void LinaColor()
    {
        if (tmpText != null)
        {
            tmpText.color = new Color(1f, 0.7f, 0.8f); 
            tmpName.color = new Color(1f, 0.7f, 0.8f); 
        }
    }
    public void PlayerColor()
    {
        if (tmpText != null)
        {
            tmpText.color = new Color(1f, 1f, 1f);
            tmpName.color = new Color(1f, 1f, 1f); 
            
        }
    }
    public void AminaColor()
    {
        if (tmpText != null)
        {
            tmpText.color = new Color(0.6f, 1f, 0.6f);
            tmpName.color = new Color(0.6f, 1f, 0.6f);  
        }
    }
    public void LarbiColor()
    {
        if (tmpText != null)
        {
            tmpText.color = new Color(1f, 0.7f, 0.5f);
            tmpName.color = new Color(1f, 0.7f, 0.5f);
        }
    }
 public void MinatuColor()
    {
        if (tmpText != null)
        {
            tmpText.color = new Color(1f, 0.5f, 0.5f);
            tmpName.color = new Color(1f, 0.5f, 0.5f);
        }
    }

    
}

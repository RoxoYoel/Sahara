using UnityEngine;
using TMPro;
using System.Collections;

public class DialogEventScript : MonoBehaviour
{
    public RPG_Move_v2 script;
    public TMP_Text tmpText;
    public TMP_Text tmpName;
    public AudioSource CocheCerrado;
    public GameObject closeCar;
    public GameObject openCar;

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

using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaFoto : MonoBehaviour
{
    public GameObject texto;
    public NombreFoto []script;
    public int num;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Foto"))
        {
            texto.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                print("f");
                script[num].CambiarEscena();
            }
        }
    }

    public void CambiarNumero(int nuevoNum)
    {
        num = nuevoNum;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Foto"))
        {
            texto.SetActive(false);
        }
    }
}

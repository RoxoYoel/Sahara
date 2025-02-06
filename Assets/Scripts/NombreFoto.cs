using UnityEngine;
using UnityEngine.SceneManagement;

public class NombreFoto : MonoBehaviour
{
    public string sceneName;
    public EscenaFoto escenaFoto;
    public int numero;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        escenaFoto.CambiarNumero(numero);
        print(sceneName);
    }

    public void CambiarEscena()
    {
        print(sceneName);
        SceneManager.LoadScene(sceneName);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class NombreFoto : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(sceneName);
    }
    public void CambiarEscena()
    {
        print(sceneName);
        SceneManager.LoadScene(sceneName);
    }
}

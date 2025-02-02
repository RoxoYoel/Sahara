using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject RedScreen;
    public GameObject YellowScreen;
    public GameObject GreenScreen;

    private void Start()
    {
        CameraRed();  // Inicia con la pantalla roja
    }

    private void Update()
    {
        // Esto ya no es necesario porque cada m�todo maneja sus transiciones.
    }

    public void LoadSceneCamara()
    {
        SceneManager.LoadScene("Camera");
    }

    public void CameraYellow()
    {
        // Activa solo la pantalla amarilla y desactiva las dem�s
        YellowScreen.SetActive(true);
        GreenScreen.SetActive(false);
        RedScreen.SetActive(false);
    }

    public void CameraGreen()
    {
        // Activa solo la pantalla verde y desactiva las dem�s
        GreenScreen.SetActive(true);
        RedScreen.SetActive(false);
        YellowScreen.SetActive(false);
    }

    public void CameraRed()
    {
        // Activa solo la pantalla roja y desactiva las dem�s
        RedScreen.SetActive(true);
        GreenScreen.SetActive(false);
        YellowScreen.SetActive(false);
    }
}

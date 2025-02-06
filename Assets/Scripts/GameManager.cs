using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject RedScreen;
    public GameObject YellowScreen;
    public GameObject GreenScreen;
    public bool Photo;
    private void Start()
    {
        CameraRed();
    }

    private void Update()
    {

    }

    public void LoadSceneCamara()
    {
        SceneManager.LoadScene("Camera");
    }

    public void CameraYellow()
    {
        YellowScreen.SetActive(true);
        GreenScreen.SetActive(false);
        RedScreen.SetActive(false);
        Photo = false;
    }

    public void CameraGreen()
    {
        GreenScreen.SetActive(true);
        RedScreen.SetActive(false);
        YellowScreen.SetActive(false);
        Photo = true;
    }

    public void CameraRed()
    {
        RedScreen.SetActive(true);
        GreenScreen.SetActive(false);
        YellowScreen.SetActive(false);
        Photo = false;
    }
    public void AlbumAmina()
    {
        SceneManager.LoadScene("AlbumAmina");
    }
    public void CambiarEscenaPrincipal()
    {
        SceneManager.LoadScene("Nacos");
    }

}

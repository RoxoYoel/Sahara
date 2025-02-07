using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject RedScreen;
    public GameObject YellowScreen;
    public GameObject GreenScreen;
    public bool Photo;
    public GameObject Album;
    private static bool AlbumsMinatu;
    private static bool AlbumsMural;
    private void Start()
    {
        Album.SetActive(false); 
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
    public void AlbumMinatu()
    {
        SceneManager.LoadScene("AlbumMinatu");
    }
    public void AlbumMural()
    {
        SceneManager.LoadScene("AlbumMural");
    }
    public void CambiarEscenaPrincipal()
    {
        SceneManager.LoadScene("Nacos");
    }
    public void CambiarEscenaPrincipal2()
    {
        SceneManager.LoadScene("DesertSC2");
    }
     public void TimeScale1()
    {
        Time.timeScale =1.0f;
    }
    public void AlbumActivo()
    {
        Album.SetActive (true);
    }

}

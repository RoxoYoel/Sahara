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
    public GameObject Minatu;
    public GameObject Mural;

    private void Start()
    {
        Minatu.SetActive(false);
        Mural.SetActive(false);

        Album.SetActive(false); 
        CameraRed();
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

    public void AlbumDesactivo()
    {
        Album.SetActive(false);
    }

    public void MinatuEnAlbum()
    {
        Minatu.SetActive (true);
    }

    public void MuralEnAlbum()
    {
        Mural.SetActive(true);
    }

    public void MinatuBoolTrue()
    {
        AlbumStaticBool.AlbumMinatu = true;
    }

    public void MuralBoolTrue()
    {
        AlbumStaticBool.AlbumMural = true;
    }
}

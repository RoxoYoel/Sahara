using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MenuScript : MonoBehaviour
{
    //PAUSA PARAMETROS
    public GameObject pauseMenuCanvas;
    private bool isPaused = false;

    //BACKGROUND INFINITO PARAMETROS
    public RectTransform background1;
    public RectTransform background2; 
    public float scrollSpeed = 100f; 
    private float backgroundWidth;

    //AUDIO PARAMETROS
    public AudioMixer audioMixer;
    public Slider volumeSlider; 


    void Start()
    {
        pauseMenuCanvas.SetActive(false);

        backgroundWidth = background1.rect.width;
        background2.anchoredPosition = new Vector2(background1.anchoredPosition.x + backgroundWidth, background1.anchoredPosition.y);

        //VOLUMEN
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            float savedVolume = PlayerPrefs.GetFloat("MusicVolume");
            volumeSlider.value = savedVolume; // Ajusta el Slider al volumen guardado
            SetVolume(savedVolume); // Aplica el volumen al AudioMixer
        }
        else
        {
            volumeSlider.value = 1; // Por defecto, el volumen al máximo
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        //BACKGROUND INFINITO
        background1.anchoredPosition += Vector2.left * scrollSpeed * Time.deltaTime;
        background2.anchoredPosition += Vector2.left * scrollSpeed * Time.deltaTime;
        if (background1.anchoredPosition.x <= -backgroundWidth)
        {
            background1.anchoredPosition = new Vector2(background2.anchoredPosition.x + backgroundWidth, background1.anchoredPosition.y);
        }
        if (background2.anchoredPosition.x <= -backgroundWidth)
        {
            background2.anchoredPosition = new Vector2(background1.anchoredPosition.x + backgroundWidth, background2.anchoredPosition.y);
        }
    }
    public void PauseGame()
    {
        pauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Exit()
    {
        print("Cerrando Juego");
        Application.Quit();
    }

    public void SetVolume(float volume)
{
    // Asegúrate de que el valor no sea menor a 0.0001
    float clampedVolume = Mathf.Max(volume, 0.0001f);
    // Convierte el valor a decibelios
    float volumeInDb = Mathf.Log10(clampedVolume) * 20;

    // Aplica el volumen al AudioMixer
    audioMixer.SetFloat("MusicVolume", volumeInDb);

    // Imprime para depuración
    Debug.Log($"Slider Value: {volume}, Converted to dB: {volumeInDb}");

    // Guarda el valor
    PlayerPrefs.SetFloat("MusicVolume", volume);
}
}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MenuScript : MonoBehaviour
{
    //PAUSA PARAMETROS
    public GameObject pauseMenuCanvas;
    public GameObject mapaCanvas;
    private bool isPaused = false;
    public GameObject settingsCanvas;

    //BACKGROUND INFINITO PARAMETROS
    public RectTransform background1;
    public RectTransform background2; 
    public float scrollSpeed = 100f; 
    private float backgroundWidth;

    public AudioClip openMenuSound;
    public AudioClip closeMenuSound;
    private AudioSource audioSource;
    public AudioMixerGroup audioMixerGroup;


    void Start()
    {
        pauseMenuCanvas.SetActive(false);

        backgroundWidth = background1.rect.width;
        background2.anchoredPosition = new Vector2(background1.anchoredPosition.x + backgroundWidth, background1.anchoredPosition.y);

        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            // Agrega automáticamente un AudioSource si no existe
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        if (audioMixerGroup != null)
        {
            audioSource.outputAudioMixerGroup = audioMixerGroup;
        }

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
                OcultarCanvas(pauseMenuCanvas);

            }
            else
            {
                PauseGame();
                MostrasCanvas(pauseMenuCanvas);
            }
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isPaused)
            {
                ResumeGame();
                OcultarCanvas(mapaCanvas);

            }
            else
            {
                PauseGame();
                MostrasCanvas(mapaCanvas);
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
        Time.timeScale = 0f;
        isPaused = true;
        PlaySound(openMenuSound);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        isPaused = false;
        PlaySound(closeMenuSound);
    }

    public void MostrasCanvas(GameObject canvas)
    {
        canvas.SetActive(true);
    }

    public void OcultarCanvas(GameObject canvas) 
    { 
        canvas.SetActive(false);
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1f;
    }
    public void Exit()
    {
        print("Cerrando Juego");
        Application.Quit();
    }
    public void ToggleSettings()
    {
        settingsCanvas.SetActive(!settingsCanvas.activeSelf);
    }
    private void PlaySound(AudioClip clip)
    {
        if (clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}

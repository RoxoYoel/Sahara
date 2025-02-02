using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject RedScreen;
    public GameObject YellowScreen;
    public GameObject GreenScreen;
    void Start()
    {
        RedScreen.SetActive(false);
    }

    void Update()
    {
        if (GreenScreen.activeSelf)
        {
            RedScreen.SetActive(false);
            YellowScreen.SetActive(false);
        }
        else if (YellowScreen.activeSelf)
        {
            GreenScreen.SetActive(false);
            RedScreen.SetActive(false);
        }
        else if (RedScreen.activeSelf)
        {
            GreenScreen.SetActive(false);
            YellowScreen.SetActive(false);
        }
       
    }

    void LoadSceneCamara()
    {
        SceneManager.LoadScene("Camera");
    }

    void CameraYellow()
    {   
        YellowScreen.SetActive(true);    
    } 
    void CameraGreen()
    {   
        GreenScreen.SetActive(true);    
    }
    void CameraRed()
    {  
        RedScreen.SetActive(true);    
    }
}

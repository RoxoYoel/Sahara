using UnityEngine;

public class PhotoCamera : MonoBehaviour
{
    public GameManager GameManager;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.CompareTag("TriggerPhoto"))
        {
            GameManager.CameraGreen();
        }
    }
    private void OnTriggerStay2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.CompareTag("TriggerPhoto"))
        {
            GameManager.CameraYellow();
        }
    }
    private void OnTriggerExit2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.CompareTag("TriggerPhoto"))
        {
            GameManager.CameraRed();
        }
    }
}

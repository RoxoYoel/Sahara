using UnityEngine;

public class PhotoCamera : MonoBehaviour
{
    public GameManager GameManager;
    void Start()
    {
        
    }
    void Update()
    {
        // Si la posici�n del objeto est� dentro de un "recuadro" definido por las coordenadas
        if ((transform.position.x > -8.3f && transform.position.x < -7.2f) &&
            (transform.position.y > 1.97f && transform.position.y < 2.61f))
        {
            GameManager.CameraGreen(); // Realiza la acci�n cuando est� dentro del recuadro
        }
    }


}

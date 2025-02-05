using UnityEngine;
using UnityEngine.UI;

public class InfiniteScrollBackground : MonoBehaviour
{
    public RectTransform background1; // Primera imagen
    public RectTransform background2; // Segunda imagen (duplicada)
    public float scrollSpeed = 100f; // Velocidad de desplazamiento

    private float backgroundWidth;

    void Start()
    {
        // Obtiene el ancho de la imagen
        backgroundWidth = background1.rect.width;
        
        // Asegura que la segunda imagen esté colocada al lado de la primera
        background2.anchoredPosition = new Vector2(background1.anchoredPosition.x + backgroundWidth, background1.anchoredPosition.y);
    }

    void Update()
    {
        // Mueve ambas imágenes a la izquierda
        background1.anchoredPosition += Vector2.left * scrollSpeed * Time.deltaTime;
        background2.anchoredPosition += Vector2.left * scrollSpeed * Time.deltaTime;

        // Si una imagen ha salido completamente de la pantalla, la reposicionamos
        if (background1.anchoredPosition.x <= -backgroundWidth)
        {
            background1.anchoredPosition = new Vector2(background2.anchoredPosition.x + backgroundWidth, background1.anchoredPosition.y);
        }

        if (background2.anchoredPosition.x <= -backgroundWidth)
        {
            background2.anchoredPosition = new Vector2(background1.anchoredPosition.x + backgroundWidth, background2.anchoredPosition.y);
        }
    }
}

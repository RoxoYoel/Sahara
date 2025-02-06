using System.Collections;
using UnityEngine;

public class CambiarSprite : MonoBehaviour
{
    public GameObject jugador;
    public Sprite nuevoSprite;
    private SpriteRenderer spriteRenderer; 

    void Start()
    {
        jugador.SetActive(false);
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(CambiarSpriteDespuesDeTiempo(5f)); 
    }
    IEnumerator CambiarSpriteDespuesDeTiempo(float segundos)
    {
        yield return new WaitForSeconds(segundos);
        jugador.SetActive(true);
        spriteRenderer.sprite = nuevoSprite; 
    }
}

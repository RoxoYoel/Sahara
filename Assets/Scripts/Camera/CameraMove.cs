using UnityEngine;

public class MouseFollower : MonoBehaviour
{
    public float followSpeed = 3f; // Ajusta la suavidad del movimiento
    public Camera mainCamera; // Referencia a la cámara principal
    public GameObject Visor;

    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }

    void Update()
    {
        Visor.transform.position = new Vector2(mainCamera.transform.position.x, mainCamera.transform.position.y);
        if (mainCamera == null) return; // Seguridad por si no hay cámara

        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z; // Mantener la profundidad correcta

        // Movimiento suave
        transform.position = Vector3.Lerp(transform.position, mousePosition, Time.deltaTime * followSpeed);
    }
}

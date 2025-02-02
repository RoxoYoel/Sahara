using UnityEngine;

public class MouseFollower : MonoBehaviour
{
    public float followSpeed = 3f; // Ajusta la suavidad del movimiento
    public Camera mainCamera; // Referencia a la cámara principal

    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main; // Obtiene la cámara principal si no se asignó
        }
    }

    void Update()
    {
        if (mainCamera == null) return; // Seguridad por si no hay cámara

        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z; // Mantener la profundidad correcta

        // Movimiento suave
        transform.position = Vector3.Lerp(transform.position, mousePosition, Time.deltaTime * followSpeed);
    }
}

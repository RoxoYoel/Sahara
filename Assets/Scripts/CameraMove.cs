using UnityEngine;

public class MouseFollower : MonoBehaviour
{
    public float followSpeed = 3f; // Ajusta la suavidad del movimiento
    public Camera mainCamera; // Referencia a la c�mara principal

    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main; // Obtiene la c�mara principal si no se asign�
        }
    }

    void Update()
    {
        if (mainCamera == null) return; // Seguridad por si no hay c�mara

        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z; // Mantener la profundidad correcta

        // Movimiento suave
        transform.position = Vector3.Lerp(transform.position, mousePosition, Time.deltaTime * followSpeed);
    }
}

using UnityEngine;

public class RotarModelo : MonoBehaviour
{
    public float velocidad = 0.2f;
    public float limiteVertical = 80f;

    float rotX = 0f;
    float rotY = 0f;

    void Update()
    {
        // -------- PC (MOUSE) --------
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X") * velocidad * 100f;
            float mouseY = Input.GetAxis("Mouse Y") * velocidad * 100f;

            rotY -= mouseX;
            rotX += mouseY;
        }

        // -------- CELULAR (TOUCH) --------
        if (Input.touchCount == 1)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Moved)
            {
                rotY -= t.deltaPosition.x * velocidad;
                rotX += t.deltaPosition.y * velocidad;
            }
        }

        // Limitar rotación vertical (para que no se voltee)
        rotX = Mathf.Clamp(rotX, -limiteVertical, limiteVertical);

        // Aplicar rotación
        transform.rotation = Quaternion.Euler(rotX, rotY, 0);
    }
}
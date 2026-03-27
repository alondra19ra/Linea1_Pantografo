using UnityEngine;

public class ZoomCamara : MonoBehaviour
{
    public float zoomTouchSpeed = 0.05f;
    public float zoomMouseSpeed = 10f;

    public float minFov = 25f;
    public float maxFov = 80f;

    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        // -------- ZOOM CON MOUSE (PC) --------
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0f)
        {
            cam.fieldOfView -= scroll * zoomMouseSpeed;
        }

        // -------- ZOOM CON PINCH (CELULAR) --------
        if (Input.touchCount == 2)
        {
            Touch t0 = Input.GetTouch(0);
            Touch t1 = Input.GetTouch(1);

            Vector2 t0Prev = t0.position - t0.deltaPosition;
            Vector2 t1Prev = t1.position - t1.deltaPosition;

            float prevDist = (t0Prev - t1Prev).magnitude;
            float currDist = (t0.position - t1.position).magnitude;

            float diff = currDist - prevDist;

            cam.fieldOfView -= diff * zoomTouchSpeed;
        }

        cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, minFov, maxFov);
    }
}
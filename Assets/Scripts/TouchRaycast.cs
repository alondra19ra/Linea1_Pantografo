using UnityEngine;

public class TouchRaycast : MonoBehaviour
{
    void Update()
    {
        // CELULAR
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                PuntoInfo p = hit.collider.GetComponent<PuntoInfo>();
                if (p != null)
                {
                    Debug.Log("Punto tocado: " + p.titulo);
                    p.Mostrar();
                }
            }
        }

        //  PC (PARA PROBAR EN EDITOR)
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                PuntoInfo p = hit.collider.GetComponent<PuntoInfo>();
                if (p != null)
                {
                    Debug.Log("Punto clickeado: " + p.titulo);
                    p.Mostrar();
                }
            }
        }
    }
}
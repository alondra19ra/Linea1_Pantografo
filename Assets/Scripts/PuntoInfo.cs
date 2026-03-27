using UnityEngine;

public class PuntoInfo : MonoBehaviour
{
    public string titulo;
    [TextArea] public string descripcion;
    public GameObject panelInfo;

    public void Mostrar()
    {
        panelInfo.SetActive(true);
        panelInfo.GetComponent<PanelInfo>().Actualizar(titulo, descripcion);
    }
}
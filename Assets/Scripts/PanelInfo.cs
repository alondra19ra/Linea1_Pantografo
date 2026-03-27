using TMPro;
using UnityEngine;

public class PanelInfo : MonoBehaviour
{
    public TextMeshProUGUI tituloText;
    public TextMeshProUGUI descripcionText;

    public void Actualizar(string titulo, string desc)
    {
        tituloText.text = titulo;
        descripcionText.text = desc;
    }

    public void Cerrar()
    {
        gameObject.SetActive(false);
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public void IrPantografo()
    {
        SceneManager.LoadScene("Pantografo");
    }

    public void IrSeguridad()
    {
        SceneManager.LoadScene("Seguridad");
    }
}


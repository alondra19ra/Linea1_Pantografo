using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadSceneManager : MonoBehaviour
{
    private void Reset()
    {
        gameObject.name = "LoadSceneManager";
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);        
    }
}

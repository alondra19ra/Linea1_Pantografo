using UnityEngine;
using System;
public abstract class Authentications : MonoBehaviour
{
    public static event Action OnSignedIn;
    public static event Action OnSignOut;
    
    protected void SignedIn()
    {
        OnSignedIn?.Invoke();
        Debug.Log("Logueado Con exito");
    }
    protected void SignOut()
    {
        OnSignOut?.Invoke();
        Debug.Log("Cerraste las secion");
    }
}

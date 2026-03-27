using System;
using UnityEngine;

public class LoginManager : MonoBehaviour
{
    [SerializeField] private LoadSceneManager loadSceneManager;
    private void Reset()
    {
        gameObject.name = "LoginManager";
    }
    private void OnEnable()
    {
        Authentications.OnSignedIn+=SignedIn;
    }
    private void OnDisable()
    {
        Authentications.OnSignedIn-=SignedIn;
    }
    private void SignedIn()
    {
        Debug.Log("Hi");
        loadSceneManager.LoadScene("Menu");
    }
}

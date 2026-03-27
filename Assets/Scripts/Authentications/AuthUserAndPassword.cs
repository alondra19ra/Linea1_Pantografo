using System;
using TMPro;
using Unity.Services.Authentication;
using Unity.Services.Core;
using UnityEngine;

public class AuthUserAndPassword : Authentications
{
    [SerializeField] private TMP_InputField userName;
    [SerializeField] private TMP_InputField passWord;
    private void Reset()
    {
        gameObject.name = "AuthUserAndPassword";
    }
    private void Awake()
    {
        try
        {
            UnityServices.InitializeAsync();
            Debug.Log("Se Inicializaron los servicios");
        }
        catch(Exception e)
        {
            Debug.LogWarning($"No se Inicializaron los servicios: {e}");
        }
    }
    public void Register()
    {
        try
        {
            AuthenticationService.Instance.AddUsernamePasswordAsync(userName.text,passWord.text);
            SignedIn();
        }
        catch(Exception e)
        {
            Debug.LogWarning(e);
        }
    }
    private void Insert()
    {
        try
        {
            AuthenticationService.Instance.SignUpWithUsernamePasswordAsync(userName.text,passWord.text);
            SignedIn();
        }
        catch(Exception e)
        {
            Debug.LogWarning(e);
        }
    }
}

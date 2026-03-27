using System;
using TMPro;
using Unity.Services.Authentication;
using Unity.Services.Core;
using UnityEngine;

public class AuthUserAndPassword : Authentications
{
    [SerializeField] private TMP_InputField userName;
    [SerializeField] private TMP_InputField passWord;
    [SerializeField] private GameObject textLogin;
    [SerializeField] private GameObject textRecord;
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
    public async void Register()
    {
        try
        {
            await AuthenticationService.Instance.SignUpWithUsernamePasswordAsync(userName.text,passWord.text);
            SignedIn();
        }
        catch(Exception e)
        {
            Debug.LogWarning(e);
            textRecord.SetActive(true);
        }
    }
    public async void Insert()
    {
        try
        {
            await AuthenticationService.Instance.SignInWithUsernamePasswordAsync(userName.text,passWord.text);
            SignedIn();
        }
        catch(Exception e)
        {
            Debug.LogWarning(e);
            textLogin.SetActive(true);
        }
    }
}

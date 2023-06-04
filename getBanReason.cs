using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Photon.Pun;
using Photon.Realtime;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;
using UnityEngine.SceneManagement;

public class getBanReason : MonoBehaviour
{
    public TextMeshPro banText;
    public TextMeshPro reasontext;
    public TextMeshPro imsad;
    public int HoursLeft;

    // Start is called before the first frame update
    void Start()
    {
        Login();
    }

    void Login()
    {
        var request = new LoginWithCustomIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccess, OnError);
    }

    void OnSuccess(LoginResult result)
    {
        banText.text = "Oops, there seems to have been an error loading the game. Try restarting or uninstalling.";
    }

    void OnError(PlayFabError error)
    {
        Debug.Log("Error while logging in/creating account!");
        if (error.Error == PlayFabErrorCode.AccountBanned)
        {
            foreach (var item in error.ErrorDetails)
            {
                HoursLeft = (int)((DateTime.Parse(item.Value[0]) - DateTime.UtcNow).TotalHours + 1.0);
                imsad.text = HoursLeft.ToString();

                reasontext.text = item.Key;
                banText.text = "You've been banned. Don't break any more rules.";
            }
        }
    }
}
    

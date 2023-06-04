using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class NameFilter : MonoBehaviour
{
    public TextMeshPro username;

    public List<string> blockedUsernames;
    string currentuser;
    string currentuserphoton;
    string blocked = "**";

    //Put This Somewhere In Your Player Prefab!

    void Update()
    {
        currentuserphoton = PhotonNetwork.LocalPlayer.NickName;
        currentuser = PlayerPrefs.GetString("Username");
        foreach (string x in blockedUsernames)
        {
            if (username.text == x)
            {
                username.text = "SpaceMonk";
            }
        }
        foreach (string x in blockedUsernames)
        {
            if (currentuser == x)
            {
                PlayerPrefs.SetString("Username", blocked);
            }
        }
        foreach (string x in blockedUsernames)
        {
            if (currentuserphoton == x)
            {
                PhotonNetwork.LocalPlayer.NickName = blocked;
            }
        }
    }
}

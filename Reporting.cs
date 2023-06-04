//�all copyright goes to flimcy owner of Chimp Kingdom�

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using UnityEngine.XR;



public class Reporting : MonoBehaviour
{
    public TextMeshPro playerUsername;

    public LeaderBoard script;

    public bool reporting;
    public bool isKey1;
    public bool isKey2;
    public bool isKey3;
    public bool isKey4;
    public bool isKey5;
    public bool isKey6;
    public bool isKey7;
    public bool isKey8;
    public bool isKey9;
    public bool isKey10;


    public bool HateSpeach;
    public bool Toxic;
    public bool Cheating;
    public bool ModAbuse;

    string webhook_link = "https://discord.com/api/webhooks/1079056531036852365/1USNsevuJ7I_8SU4Fg1a6yX2wrXuxQ5wGCIRKR4l0cO7FyNX7rJka1FX2FM00IxVCFy3";

    private void OnTriggerEnter(Collider other)
    {
        base.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        if (reporting)
        {
            if (isKey1)
            {
                script.activereportperson = script.usernames[0];
            }
            if (isKey2)
            {
                script.activereportperson = script.usernames[1];
            }
            if (isKey3)
            {
                script.activereportperson = script.usernames[2];
            }
            if (isKey4)
            {
                script.activereportperson = script.usernames[3];
            }
            if (isKey5)
            {
                script.activereportperson = script.usernames[4];
            }
            if (isKey6)
            {
                script.activereportperson = script.usernames[5];
            }
            if (isKey7)
            {
                script.activereportperson = script.usernames[6];
            }
            if (isKey8)
            {
                script.activereportperson = script.usernames[7];
            }
            if (isKey9)
            {
                script.activereportperson = script.usernames[8];
            }
            if (isKey10)
            {
                script.activereportperson = script.usernames[9];
            }
            if (Toxic)
            {
                StartCoroutine(SendWebhook(webhook_link, "**Offender Username: **" + script.activereportperson + "\n" + "**Reason: **" + "Toxic" + "     "));
            }
            if (HateSpeach)
            {
                if (script.activereportperson == "")
                {

                }
                else
                {
                    StartCoroutine(SendWebhook(webhook_link, "**Offender Username: **" + script.activereportperson + "\n" + "**Reason: **" + "HateSpeach" + "     "));
                }
            }
            if (Cheating)
            {
                if (script.activereportperson == "")
                {

                }
                else
                {
                    StartCoroutine(SendWebhook(webhook_link, "**Offender Username: **" + script.activereportperson + "\n" + "**Reason: **" + "Cheating" + "     "));
                }
            }
            if (ModAbuse)
            {
                if (script.activereportperson == "")
                {

                }
                else
                {
                    StartCoroutine(SendWebhook(webhook_link, "**Offender Username: **" + script.activereportperson + "\n" + "**Reason: **" + "ModAbuse" + "     "));
                }
            }
        }
    }

    IEnumerator SendWebhook(string link, string message)
    {
        WWWForm form = new WWWForm();
        form.AddField("content", message);
        using (UnityWebRequest www = UnityWebRequest.Post(link, form))
        {
            yield return www.SendWebRequest();
        }

    }
}
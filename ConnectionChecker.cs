using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionChecker : MonoBehaviour
{
public GameObject EnableWhenWifiIsOff;
public GameObject EnableWhenWifiIsOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Application.internetReachability == NetworkReachability.NotReachable)
        {
        EnableWhenWifiIsOff.SetActive(true);
                EnableWhenWifiIsOn.SetActive(false);
            Debug.Log("Error. Check internet connection!");
        }
        else
        {
        
        EnableWhenWifiIsOn.SetActive(true);
                EnableWhenWifiIsOff.SetActive(false);
        }
    }
}

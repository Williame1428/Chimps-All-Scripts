using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VentOpenPro : MonoBehaviour
{
    [Header("Custom Event")]
    public UnityEvent myEvents;
    public string ModAc;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == ModAc)
        {
            print("myEventTriggerOnEnter Activated. Triggering" + myEvents);
            myEvents.Invoke();
        }

        if (myEvents == null)
        {
            print("myEventTriggerOnEnter was triggered but myEvents was null");
        }
      
    }
}
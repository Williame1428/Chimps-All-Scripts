using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class platforms : MonoBehaviour
{

    private InputDevice targetDevice;
    private GameObject Cube;
    public bool isSpawned = false;
    public GameObject ObjecttoSpawn;
    public Transform hand;
    public InputDeviceCharacteristics Controller;
    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(Controller, devices);
       
        if(devices.Count > 0)
        {
            targetDevice = devices[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue) && gripValue > 0.1f)
        {   
            if(isSpawned == false)
            {
                Destroy(Cube);
                isSpawned = true;
               float X = hand.transform.position.x;
               float Z = hand.transform.position.z;
               float Y = hand.transform.position.y - 0.1f;
                Cube = Instantiate(ObjecttoSpawn, new Vector3(X, Y, Z), Quaternion.identity);              
            }
        }
        else
        {
            isSpawned = false;
            Destroy(Cube);
        }
    }
}

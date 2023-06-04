using UnityEngine;
using Photon.VR;

public class JoinServer3 : MonoBehaviour
{

    public string Handtag;


    private async void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == Handtag)
        {
            //Join code:
            int maxPlayers = 10;
            PhotonVRManager.JoinPrivateRoom("Server3", maxPlayers);
        }
    }
}

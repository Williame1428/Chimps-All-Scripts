using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.VR;
using Photon.Pun;
using Photon.Realtime;
using Photon.VR.Player;
using GorillaLocomotion;
using Photon;
using Photon.Pun.UtilityScripts;

public class leave : MonoBehaviour
{
	
	private void OnTriggerEnter(Collider other)
	{
		PhotonNetwork.LeaveRoom();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace WIJAA
{
	/// <summary>
	/// This is a class that makes it easier to make common calls to classes in NetworkManager
	/// </summary>
	public class NetworkManagerWrapper : MonoBehaviour {

		public void SetIP(string newIP)
		{
			FindObjectOfType<NetworkManager>().networkAddress = newIP;
		}

		public void ConnectToGame()
		{
			FindObjectOfType<NetworkManager>().StartClient();
		}

		public void HostGame()
		{
			FindObjectOfType<NetworkManager>().StartHost();
		}

		string ipText;
		public Text ipTextBox;
		void Start()
		{
			ipText = Network.player.ipAddress;

			if(ipTextBox != null)
				ipTextBox.text = "IP: " + ipText;
		}
	}
}

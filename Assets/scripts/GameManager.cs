using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace WIJAA
{
	public class GameManager : NetworkBehaviour {

		public override void OnStartClient()
		{
			if(isServer && isClient)
			{
				Debug.Log("Logged in as Host");
				foreach(var gObject in GameObject.FindGameObjectsWithTag("Player")) //we want to disable all objects that aren't meant for the host. IE- meant for the player
				{
					gObject.SetActive(false);
				}
			}
			else if(isClient)
			{
				Debug.Log("Logged in as Player");
				foreach(var gObject in GameObject.FindGameObjectsWithTag("Host"))
				{
					gObject.SetActive(false);
				}
			}
		}
	}
}
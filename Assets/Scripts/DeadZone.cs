using UnityEngine;
using System.Collections;

public class DeadZone : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider collider)
	{
		GM.instance.LoseLife();
	}
}

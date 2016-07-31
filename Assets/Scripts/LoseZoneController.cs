using UnityEngine;
using System.Collections;

public class LoseZoneController : MonoBehaviour {

	void OnTriggerEnter(Collider collider)
	{
		Debug.Log ("LoseZoneController - OnTriggerEnter");

		if(collider.CompareTag("Player"))
		{
			GameManager.instance.GameOver ();
		}
	}
}

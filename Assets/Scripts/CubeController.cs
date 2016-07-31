using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	void OnTriggerEnter(Collider collider) 
	{
		if(collider.gameObject.CompareTag("LoseZone")) 
		{
			GameManager.instance.HitBrick ();
			Destroy (gameObject);	
		}
	}
}

using UnityEngine;
using System.Collections;

public class RotatinCubeController : MonoBehaviour {

	void Update () {

		transform.Rotate (new Vector3 (15f, 30f, 45f) * Time.deltaTime);
	}

	void OnTriggerEnter() 
	{
		Debug.Log ("RotatinCubeController - OnTriggerEnter");
		GameManager.instance.HitBrick ();
		Destroy (gameObject);
	}
}

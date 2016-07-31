using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float forceAdition;
	private Rigidbody rigid;

	void Start ()
	{
		rigid = GetComponent<Rigidbody> ();
	}

	// Called before any physics calculations
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal"); 

		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		//Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);

		rigid.AddForce (movement * forceAdition);
	}

	// the parameter is optional. But if you wil not need it, it is best not
	// to add it in the function. Since it will be necessary additional calculations.
	void OnCollisionEnter() 
	{
		Debug.Log ("onCollisionEnter detected - Ball");
	}

	void OnTriggerEnter()
	{
		Debug.Log("PlayerController - OnTriggerEnter");
	}
}


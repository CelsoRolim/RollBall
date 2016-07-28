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

	// Update is called before rendering a frame.
}


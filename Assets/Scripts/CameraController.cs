using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject ball;
	private Vector3 offset;

	private Vector3 ballPosition;
	private Vector3 cameraPosition;

	// Use this for initialization
	void Start () {
	
		// calculate offset, based on first position of the camera and the ball.
		ballPosition = ball.GetComponent<Transform> ().position;
		cameraPosition = this.GetComponent<Transform> ().position;

		offset = ballPosition - cameraPosition;
	}
	
	// Garanteed that will excute after all items processed by Update
	void LateUpdate () {
	
		// get current position of the ball
		ballPosition = ball.GetComponent<Transform> ().position;

		// calculate the next position of the camera. It will follow the ball.
		cameraPosition = ballPosition - offset;
		this.GetComponent<Transform> ().position = cameraPosition;
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public GameObject winText;
	public GameObject loseText;
	public TextMesh hitBricksCountText;
	public int numBricksInGame;

	private int totalBricks = 0;
	private float resetDelay = 1f;

	void Awake()
	{
		if (instance == null) {
			instance = this;
		} else if(instance != this) 
		{
			Destroy (gameObject);
		}
	}

	void Start()
	{
		totalBricks = 0;
	}

	public void HitBrick()
	{
		totalBricks++;
		hitBricksCountText.text = "Points: " + totalBricks;
		if(totalBricks >= numBricksInGame) 
		{
			Win ();
		}
	}

	public void GameOver()
	{
		loseText.SetActive (true);

		Time.timeScale = .5f;
		Invoke ("Reset", resetDelay);
	}

	public void Win()
	{
		winText.SetActive (true);

		Time.timeScale = .5f;
		Invoke ("Reset", resetDelay);
	}

	public void Reset()
	{
		Time.timeScale = 1f;

		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}
}

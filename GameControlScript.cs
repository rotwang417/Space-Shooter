using UnityEngine;
using System.Collections;

public class GameControlScript : MonoBehaviour {

	bool isRunning = true;
	int playerScore = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddScore()
	{
		playerScore++;
	}

	public void PlayerDied()
	{
		isRunning = false;
	}

	void OnGUI()
	{
		if(isRunning == true)
		{
		GUI.Label (new Rect(5, 5, 100, 30), "Punkty: " + playerScore);
	}
	else
	{
		GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "Koniec gry. Liczba zdobytych punktow: " + playerScore);
	}
	}

}

using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	float speed = 10f;

	GameControlScript control;

	// Use this for initialization
	void Start () {
		control = GameObject.Find("GameControl").GetComponent<GameControlScript>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0f, speed * Time.deltaTime, 0f);
	
	}

	void OnCollisionEnter(Collision other)
	{
		Destroy(other.gameObject);
		control.AddScore();
		Destroy(this.gameObject);
	}
}

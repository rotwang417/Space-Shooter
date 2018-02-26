using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour {
	public float speed = -2;
	public GameObject Background;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0f, speed * Time.deltaTime, 0f);
		if(transform.position.y <= -15)
		{
			transform.Translate(0f, 30f, 0f);
		}
	}
}

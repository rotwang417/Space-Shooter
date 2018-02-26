using UnityEngine;
using System.Collections;

public class MeteorScript : MonoBehaviour {
	
	float speed = -5f;
	float rotation;
	
	// Use this for initialization
	void Start () {
		rotation = Random.Range(-40, 40);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0f, speed * Time.deltaTime, 0f);
		transform.Rotate(0f, rotation * Time.deltaTime, 0f);
		
	}
}

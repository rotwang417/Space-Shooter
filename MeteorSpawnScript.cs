using UnityEngine;
using System.Collections;

public class MeteorSpawnScript : MonoBehaviour {

	float spawnThreshold = 100;
	float spawnDecrement = .1f;

	public GameObject meteor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Random.Range(0, spawnThreshold) <= 1)
		{
			Vector3 pos = transform.position;
			Instantiate(meteor, new Vector3(pos.x + Random.Range(-6, 6), pos.y, pos.z), Quaternion.identity);
			
			spawnThreshold -= spawnDecrement;
			if(spawnThreshold < 2)
			{
				spawnThreshold = 2;
			}
		}
	
	}
}

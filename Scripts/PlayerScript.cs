using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float speed = 10f;

	public GameObject bullet;

	public GameControlScript control;

    public AudioClip fail, shoot;

    public float bulletThreshold = .25f;
	float elapsedTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		elapsedTime += Time.deltaTime;
		transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f);
		//transform.Translate(Input.acceleration.x * speed * Time.deltaTime, 0f, 0f);
		transform.Translate(0f, 0f, Input.GetAxis("Vertical") * speed * Time.deltaTime);
		//transform.Translate(0f, 0f, Input.acceleration.y * speed * Time.deltaTime);

		if(Input.touches.Length > 0)
		{
			transform.Translate(Input.touches[0].deltaPosition.x*Time.deltaTime, 0f, 0f);
			transform.Translate(0f, 0f, Input.touches[0].deltaPosition.y*Time.deltaTime);
		}

		if(Input.GetButtonDown("Jump") || Input.touches.Length > 0)
		{
			if(elapsedTime > bulletThreshold)
			{
                AudioSource.PlayClipAtPoint(shoot, transform.position);
				Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 2f, -5f), Quaternion.identity);
				elapsedTime = 0f;
			}	
	}
}
void OnTriggerEnter(Collider other)
	{
        Destroy(other.gameObject);
		control.PlayerDied();
        AudioSource.PlayClipAtPoint(fail, transform.position);
        Destroy(this.gameObject);
	}
}
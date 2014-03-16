using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour {

	public float speed;
	public AudioClip pong, explosion;

	private Rigidbody2D thisRigidbody;
	private AudioSource thisAudio;

	void Awake () {
		thisRigidbody = rigidbody2D; //Caching the rigidbody2D
		thisAudio = audio;

		thisRigidbody.velocity = Vector2.up*speed; //Velocity of the ball
	}

	void FixedUpdate()
	{
		thisRigidbody.velocity += Vector2.one*Time.deltaTime; //Increment the velocity
	}

	void OnCollisionEnter2D(Collision2D collision)
	{

		switch(collision.gameObject.name) //If collisions...
		{
		case "Bot": //Lose and reload the level
			Application.LoadLevel(Application.loadedLevelName);
			break;
		case "Block": //Sound of explosion of the block
			thisAudio.PlayOneShot(explosion);
			break;
		default: //Sound of bounce
			thisAudio.PlayOneShot(pong);
			break;
		}
	}
}

using UnityEngine;
using System.Collections;

public class PressStart : MonoBehaviour {

	void FixedUpdate () {
		if(Input.GetKey(KeyCode.Space)) //If space key is pressed...
		{
			Application.LoadLevel(1); //Load the first level of the game
		}
	}
}

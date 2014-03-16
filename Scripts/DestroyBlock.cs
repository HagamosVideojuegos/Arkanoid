using UnityEngine;
using System.Collections;

public class DestroyBlock : MonoBehaviour {

	private GameObject thisGameObject;
	private Transform thisTransform;

	void Awake() { //Caching the objects
		thisGameObject = gameObject;
		thisTransform = transform;
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if(thisTransform.parent.childCount == 1) //If the last block is broken change the level
		{
			Application.LoadLevel(Application.loadedLevel+1);
		} else { //Else destroy this block
			Destroy(thisGameObject);
		}
	}
}

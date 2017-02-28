using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += new Vector3 (0, -0.02f, 0);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Bullet") {
			Destroy (this.gameObject);
			Destroy (col.gameObject);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public GameObject Bullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			gameObject.transform.position += new Vector3 (0.05f, 0, 0);
		}else if (Input.GetKey (KeyCode.LeftArrow)) {
			gameObject.transform.position += new Vector3 (-0.05f, 0, 0);
		}else if (Input.GetKey (KeyCode.UpArrow)) {
			gameObject.transform.position += new Vector3 (0, 0.05f, 0);
		}else if (Input.GetKey (KeyCode.DownArrow)) {
			gameObject.transform.position += new Vector3 (0, -0.05f, 0);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			Vector3 pos = gameObject.transform.position + new Vector3 (0, 0.4f, 0);
			Instantiate (Bullet, pos, gameObject.transform.rotation);
		}
	}
}

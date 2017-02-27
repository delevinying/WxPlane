using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

	public GameObject Bad;
	public float time;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 1f) {
			Vector3 pos = new Vector3 (Random.Range (-1.5f, 1.5f), 4f, 0);
			Instantiate (Bad, pos, transform.rotation);
			time = 0f;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSound : MonoBehaviour {

	public AudioClip sound;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//衝突時に呼ばれる関数
	void OnCollisionEnter2D (Collision2D collision){

		if (collision.gameObject.tag == "block") {
			AudioSource.PlayClipAtPoint (sound, transform.position);
		
		} else if (collision.gameObject.tag == "ground") {
			AudioSource.PlayClipAtPoint (sound, transform.position);
		}

	}
}

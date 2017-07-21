using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal");
		transform.Translate(x * 0.2F, 0, 0);
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Enemy(Clone)") {
			Vector3 scale = transform.localScale;
			scale.x -= Random.Range(0.1F, 0.5F);
			transform.localScale = scale;

			if (transform.localScale.x < 1.0F) {
				scale.x = 1.0F;
				transform.localScale = scale;
			}
		}
	}
}

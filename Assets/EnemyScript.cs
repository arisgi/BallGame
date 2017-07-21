using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.z -= 0.1F;
		transform.position = pos;
		transform.Rotate(1, 1, 1);

		if (transform.position.z < -12.0F) {
			Application.LoadLevel("GameOver");
		}
	}

	void OnCollisionEnter() {
		Destroy(gameObject);
	}
}

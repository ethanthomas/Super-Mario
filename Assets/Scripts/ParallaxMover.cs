using UnityEngine;
using System.Collections;

public class ParallaxMover : MonoBehaviour {
	
	Rigidbody2D player, pipe;

	void Start () {
		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");
		GameObject pipeCannon = GameObject.FindGameObjectWithTag ("Pipe");
		if (player_go == null || pipeCannon == null) {
			Debug.LogError("No object found");
			return;
		}
		player = player_go.rigidbody2D;
		pipe = pipeCannon.rigidbody2D;
	}

	// Update is called once per frame
	void FixedUpdate () {
		float vel = player.velocity.x * 0.75f;
		transform.position = transform.position + Vector3.right * vel * Time.deltaTime;
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				
		}
	}
}

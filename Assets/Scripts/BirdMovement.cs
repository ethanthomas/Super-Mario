using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour {

	Vector3 velocity = Vector3.zero;

	Animator animator;
	bool right, left, down, jump, superJump;

	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator> ();
	}
	//Graphics update here
	void Update(){
		if (Input.GetMouseButtonDown (0) || Input.GetKeyDown (KeyCode.Space)) {
//			if (transform.position.y >= -0.58f && transform.position.y <= -0.55f)
			if (rigidbody2D.velocity.y < 0.002f && rigidbody2D.velocity.y > -0.002f)
				jump = true;
		} if (Input.GetKey(KeyCode.RightArrow)) {
			right = true;
		} if (Input.GetKey(KeyCode.LeftArrow)) {
			if (transform.position.x >= 0.6854517f) 
				left = true;
		} if (Input.GetKeyDown(KeyCode.UpArrow)) {
//			if (transform.position.y >= -0.58f && transform.position.y <= -0.55f)
			if (rigidbody2D.velocity.y < 0.002f && rigidbody2D.velocity.y > -0.002f)
				jump = true;
		} if (Input.GetKey(KeyCode.DownArrow)) {
			down = true;
		} 
	}
	
	// Update is called once per frame
	// Physics updates here
	void FixedUpdate () {
//		transform.rotation = ;
//		transform.rotation = 0.0f;
		if (jump) {
			rigidbody2D.AddForce(Vector2.up * 180.0f);
//			rigidbody2D.AddForce(Vector2.right * 450.0f);
			jump = false;
		} if (right) {
			transform.position = new Vector2(transform.position.x + 0.015f, transform.position.y);
			right = false;
		} if (left) {
			transform.position = new Vector2(transform.position.x - 0.015f, transform.position.y);
			left = false;
		} if (down) {
			rigidbody2D.AddForce (Vector2.up * -20.0f);
			down = false;
		} if (superJump) {
			rigidbody2D.AddForce(Vector2.up * 100.0f);
			superJump = false; 
		}
	}
	
	void OnCollisionEnter2D(Collision2D collision){

	}
}

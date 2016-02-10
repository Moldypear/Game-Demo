using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	public float maxSpeed = 10f;

	bool facingRight = true;

	public float jumpForce = 700f;


	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;


	// Use this for initialization
//	void Start () {
//	
//	}

	void FixedUpdate (){
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);

		float move = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && (grounded == true)) {
			GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, jumpForce));
		}
	}
}

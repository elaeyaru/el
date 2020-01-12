using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {
	public float speed;
	private Rigidbody2D body;
	private Vector2 Velocity;

	void Start () {
		body = GetComponent<Rigidbody2D>();
	}

	void Update () {
		Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		Velocity = moveInput.normalized * speed;
	}

	void FixedUpdate () {
		body.MovePosition (body.position + Velocity * Time.fixedDeltaTime);
	}
}

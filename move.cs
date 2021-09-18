using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour 
{
	public float movespeed;
	public Rigidbody rb;
	float dirX;
	
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		dirX = Input.acceleration.x * movespeed;
		transform.position = new Vector3 (Mathf.Clamp (transform.position.x, -20.3f, 20.3f),transform.position.y, transform.position.z);
		transform.Rotate(0,50*Time.deltaTime,0);


		rb.velocity = new Vector3 (dirX, 0f, 0f);
	}
}

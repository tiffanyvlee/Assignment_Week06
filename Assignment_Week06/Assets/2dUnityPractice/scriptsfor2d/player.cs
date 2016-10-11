using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	float acceleration = 50;
	Rigidbody thisRigidBody;

	void Start () {
		thisRigidBody = GetComponent<Rigidbody>();
	}

	void Update () {
		thisRigidBody.AddForce( Vector3.right * Input.GetAxis( "Horizontal" ) * acceleration  );
		thisRigidBody.AddForce( Vector3.forward * Input.GetAxis("Vertical") * acceleration );
	
	}


	}

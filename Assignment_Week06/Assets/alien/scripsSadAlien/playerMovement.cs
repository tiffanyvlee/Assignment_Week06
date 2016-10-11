using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {


		float acceleration = 0.8f;
		float rotatespeed = 3;
		Rigidbody2D thisRigidBody;

		// Use this for initialization
		void Start () {
			thisRigidBody = GetComponent<Rigidbody2D>();
		}

		// Update is called once per frame
		void Update () {
			thisRigidBody.AddForce( Vector3.up * Input.GetAxis( "Vertical" ));
			thisRigidBody.AddForce( Vector3.right * Input.GetAxis("Horizontal") );
			if (Input.GetKey (KeyCode.X)) {
				print("fly bird forward");
				transform.Rotate( Vector3.forward * rotatespeed);
			}
		if (Input.GetKey (KeyCode.Z)) {
			print ("fly bird forward");
			transform.Rotate (Vector3.back * rotatespeed);
		}
		}

	}

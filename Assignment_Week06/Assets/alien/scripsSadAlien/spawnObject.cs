using UnityEngine;
using System.Collections;

public class spawnObject : MonoBehaviour {
	






	public GameObject sock1;

	public GameObject undies1;

	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		

				//Debug.Log ("make tracks");
				//spawn a ufo2 prefab
				//Instantiate (ufo2, transform.position, transform.rotation);



		if ( Input.GetKeyDown (KeyCode.X) ) {
			GameObject temp = Instantiate( sock1, transform.position, transform.rotation ) as GameObject;
			temp.GetComponent<Rigidbody> ().AddForce (Vector3.right * 1000);
		}

		if ( Input.GetKeyDown (KeyCode.Z) ) {
			GameObject temp = Instantiate( undies1, transform.position, transform.rotation ) as GameObject;
			temp.GetComponent<Rigidbody> ().AddForce (Vector3.up * 10000);
		}
	
	
	}
}
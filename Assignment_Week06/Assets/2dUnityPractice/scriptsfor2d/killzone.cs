using UnityEngine;
using System.Collections;

public class killzone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
		int lives = 30;

		void OnTriggerExit( Collider otherObj){
			otherObj.transform.position = otherObj.transform.position + Vector3.up * 10;
			otherObj.gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			Debug.Log ("thing moving out of the box");
	}
}

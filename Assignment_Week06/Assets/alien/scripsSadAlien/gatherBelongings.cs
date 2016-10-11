using UnityEngine;
using System.Collections;

public class gatherBelongings : MonoBehaviour {


	void OnTriggerEnter2D( Collider2D other) {
		Destroy (other.gameObject);		
	}
//	void OnTriggerExit2D( Collider2D otherObj){
//		otherObj.transform.position = otherObj.transform.position + Vector3.up * 40;
//		otherObj.gameObject.GetComponent<Rigidbody2D> ().velocity = Vector3.zero;
//		Debug.Log ("thing moving out of the box");
//	}



	//int lives = 30;
//
//	void OnTriggerExit2D( Collider2D otherObj){
//		otherObj.transform.position = otherObj.transform.position + Vector3.up * 10;
//		otherObj.gameObject.GetComponent<Rigidbody2D> ().velocity = Vector3.up * 10;
//		Debug.Log ("thing moving out of the box");
//	}
}

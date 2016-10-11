using UnityEngine;
using System.Collections;

public class spawnEnemy1 : MonoBehaviour {

	public GameObject enemy;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {




		if (Input.GetKeyDown (KeyCode.C)) {
			GameObject temp = Instantiate (enemy, transform.position, transform.rotation) as GameObject;
			temp.GetComponent<Rigidbody2D> ().AddForce (Vector3.right * 10);
		}
	}
}

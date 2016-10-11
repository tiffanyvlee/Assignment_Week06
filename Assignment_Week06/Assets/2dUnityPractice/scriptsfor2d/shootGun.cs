using UnityEngine;
using System.Collections;

public class shootGun : MonoBehaviour {

	public GameObject bullet;
	private bool canFire = true;
	public float rateOfFire = .7f;
	public AudioClip laserSound;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.C) && canFire == true) {
			canFire = false;
			StartCoroutine ("reload");
			GameObject temp = Instantiate (bullet, transform.position, transform.rotation) as GameObject;
			temp.GetComponent<Rigidbody2D> ().AddForce (temp.transform.up * 100);


			//GetComponent<AudioClip>.Play(); 

			//GetComponent<AudioSource>()
		}
			

	}
	IEnumerator reload() {
		yield return new WaitForSeconds ( rateOfFire );
		canFire = true;
	}



}
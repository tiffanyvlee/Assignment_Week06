using UnityEngine;
using System.Collections;

public class cameraShake : MonoBehaviour {

	Transform origLocation;

	public float numSecondsToShake = 2f;

	// Use this for initialization
	void Start () {
		origLocation = transform;
	}

	// Update is called once per frame
	void Update () {

		//transform.position = origLocation.position + Random.insideUnitSphere;
		if (Input.GetKeyDown (KeyCode.S)) {
			StartCoroutine ("shakeCam");
		}
	}
	IEnumerator shakeCam() {

		//shake for a number of seconds
		float timeLeft = numSecondsToShake;
		while (timeLeft > 0) {
			transform.position = origLocation.position + Random.insideUnitSphere;
			timeLeft -= Time.deltaTime;
			yield return null;  //stops the loop from continuing this time
		}
		//return the camera to the orig position;
		transform.position = origLocation.position;

	}
}

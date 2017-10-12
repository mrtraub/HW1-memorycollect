using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour {
	public List<string> inventory;
	private bool isR = false;
	private bool isB = false;
	private bool isM = false;
	public GameObject lose;
	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Collectable") {
			other.GetComponent<Collectable> ().Collect ();
			inventory.Add (other.GetComponent<Collectable> ().description);
			Debug.Log ("collect");
		}
		if (other.name == "Red Sphere") {
			Debug.Log ("got a red");
			if (isB == true || isM == true) {
				lose.SetActive (true);
				Debug.Log ("you lose");
			} else if (isR == true) {
				isR = false;
				Debug.Log ("two reds");
			} else {
				isR = true;
				Debug.Log ("first reds");
			}
			
		}
		if (other.name == "Blue Sphere") {
			if (isR == true || isM == true) {
				lose.SetActive (true);

			} else if (isB == true) {
				isB = false;
			} else
				isB = true;
		}
		if (other.name == "Mauve Sphere") {
			if (isB == true || isR == true) {
				lose.SetActive (true);
			} else if (isM == true) {
				isM = false;
			} else
				isM = true;
		}

		//GetComponent<LightUnlock> ().CheckInventory ();
	}

}
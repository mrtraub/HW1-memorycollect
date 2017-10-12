using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour {
	public Collector player;
	public GameObject item;
	public GameObject dirlight;
	public int minimumAmount;
	public int maximumAmount;
	public bool deploy = false;
	public bool deploy2 = false;
	public GameObject win;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CheckInventory ();
	}

	public void CheckInventory() {

		if (player.inventory.Count % 2 == 1) {
			dirlight.SetActive (false);
		}
		if (player.inventory.Count % 2 == 0){
			dirlight.SetActive (true);
		}
		if (player.inventory.Count == 2) {
			if (deploy == false) {
				int numberOfItemsToDrop = Random.Range (minimumAmount, maximumAmount);
				for (int i = 0; i < numberOfItemsToDrop; i++) {
					GameObject showerItem = (GameObject)Instantiate (item, transform);
					showerItem.transform.Translate (Random.Range (-15.0f, 15.0f), 10, Random.Range (-15.0f, 15.0f));
					showerItem.SetActive (true);
				}
				deploy = true;
			}
		}
		if (player.inventory.Count == 4) {
			if (deploy2 == false) {
				int numberOfItemsToDrop = Random.Range (minimumAmount, maximumAmount);
				for(int i = 0; i < numberOfItemsToDrop; i++) {
					GameObject showerItem = (GameObject)Instantiate (item, transform);
					showerItem.transform.Translate (Random.Range (-15.0f, 15.0f), 10, Random.Range (-15.0f, 15.0f));
					showerItem.SetActive(true);
				}
				deploy2 = true;
			}
		}
		if (player.inventory.Count == 6) {
			win.SetActive (true);
		}

	}
}

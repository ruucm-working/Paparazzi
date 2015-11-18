using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {

	public GameObject enterBtn = null;
	public GameObject friendBtn = null;

	void OnTriggerEnter2D(Collider2D coll) {
		if(coll.tag == "Door")
			enterBtn.SetActive (true);
		if (coll.tag == "Friend")
			friendBtn.SetActive (true);
	}
	void OnTriggerExit2D(Collider2D coll) {
		if(coll.tag == "Door")
			enterBtn.SetActive (false);
		if (coll.tag == "Friend")
			friendBtn.SetActive (false);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

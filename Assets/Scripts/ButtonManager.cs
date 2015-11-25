using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {
<<<<<<< HEAD
	
	public GameObject enterBtn = null;
	public GameObject friendBtn = null;
	
=======

	public GameObject enterBtn = null;
	public GameObject friendBtn = null;

>>>>>>> HSY_2
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
<<<<<<< HEAD
	
	// Use this for initialization
	void Start () {
		
=======

	// Use this for initialization
	void Start () {
	
>>>>>>> HSY_2
	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
		
	}
}
=======
	
	}
}
>>>>>>> HSY_2

using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {

	
	public GameObject enterBtn = null;
	public GameObject enterBtn2 = null;
	public GameObject friendBtn = null;
	public GameObject exitBtn = null;
	public GameObject shotBtn = null;
	

	void OnTriggerEnter2D(Collider2D coll) {
		if(coll.tag == "EnterDoor")
			enterBtn.SetActive (true);
		if(coll.tag == "EnterDoor2")
			enterBtn2.SetActive (true);
		if (coll.tag == "Friend")
			friendBtn.SetActive (true);
		if(coll.tag == "ExitDoor")
			exitBtn.SetActive (true);
		if(coll.tag == "Shot")
			shotBtn.SetActive (true);
	}
	void OnTriggerExit2D(Collider2D coll) {
		if(coll.tag == "EnterDoor")
			enterBtn.SetActive (false);
		if(coll.tag == "EnterDoor2")
			enterBtn2.SetActive (false);
		if (coll.tag == "Friend")
			friendBtn.SetActive (false);
		if(coll.tag == "ExitDoor")
			exitBtn.SetActive (false);
		if(coll.tag == "Shot")
			shotBtn.SetActive (false);
	}  

	// Use this for initialization 
	void Start () {
		

	}
	 
	// Update is called once per frame
	void Update () {

		
	}
}


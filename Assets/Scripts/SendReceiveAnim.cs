using UnityEngine;
using System.Collections;

public class SendReceiveAnim : MonoBehaviour {

	
	Animator anim;

	// Use this for initialization
	void Start () {

		anim = GameObject.Find ("run").GetComponent<Animator> ();

		
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "SendArea")
			anim.SetTrigger ("receive");


//			enterBtn.SetActive (true);
//		if(coll.tag == "EnterDoor2")
//			enterBtn2.SetActive (true);
//		if (coll.tag == "Friend")
//			friendBtn.SetActive (true);
//		if(coll.tag == "ExitDoor")
//			exitBtn.SetActive (true);
//		if(coll.tag == "Shot")
//			shotBtn.SetActive (true);
	}
}

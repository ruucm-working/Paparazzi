using UnityEngine;
using System.Collections;

public class RestroomClickButton : MonoBehaviour {

	Animator anim;


	void Start()
	{
		anim = GameObject.Find ("run").GetComponent<Animator> ();

	}

	void Update()
	{
		Debug.Log ("update");
		if (Input.GetMouseButtonDown (0)) {
		
		}

		if (Input.GetButtonDown ("Jump")) {
			Debug.Log ("Enter Button");
			
			
			anim.SetTrigger("shot");
		}
	}

//
//	void OnGUI() {
//		Event e = Event.current;
//		if (e.isKey)
//			Debug.Log("Detected key code: " + e.keyCode);
//		
//	}
//	
	
	
}
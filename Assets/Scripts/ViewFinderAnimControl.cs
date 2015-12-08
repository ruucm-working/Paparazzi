using UnityEngine;
using System.Collections;

public class ViewFinderAnimControl : MonoBehaviour {

	Animator anim;


//	public GameObject view_finder = null;


	void Start()
	{
		anim = GameObject.Find ("viewfinder11").GetComponent<Animator> ();

	}

	void Update()
	{
//		Debug.Log ("update");
//		if (Input.GetMouseButtonDown (0)) {
//		
//		}

		if (Input.GetButtonDown ("Jump")) {
			Debug.Log ("Enter Button");
			
			
//			anim.SetTrigger("shot");
			anim.SetTrigger ("shot");
//			view_finder.SetActive (true);

//			Debug.Log (SingleTone.TakeShot[0]) ;
		} 
//
//		else {
//			view_finder.SetActive (false);
//			anim.SetBool("isShoting",false);
//
//		}

		
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
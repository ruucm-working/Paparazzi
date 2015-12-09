using UnityEngine;
using System.Collections;

public class RestroomClickButton : MonoBehaviour {

	Animator anim;


//	public GameObject view_finder = null;


	void Start()
	{
		anim = GameObject.Find ("run").GetComponent<Animator> ();

		Debug.Log (SingleTone.Instance.a1) ; 

	}

	void Update()
	{
//		Debug.Log ("update");
//		if (Input.GetMouseButtonDown (0)) {
//		
//		}

		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Enter Button");
			
			
			anim.SetTrigger("shot");
//			anim.SetBool ("isShoting", true);
//			view_finder.SetActive (true);

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
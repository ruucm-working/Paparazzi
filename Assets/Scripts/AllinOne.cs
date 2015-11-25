using UnityEngine;
using System.Collections;

public class AllinOne : MonoBehaviour {


	GameObject _dialogPanel;




	void Awake(){


		_dialogPanel = GameObject.FindGameObjectWithTag ("DialogPanel");
		_dialogPanel.SetActive (false);

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

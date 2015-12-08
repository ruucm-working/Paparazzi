using UnityEngine;
using System.Collections;

public class EndingScene : MonoBehaviour {

	private float timeCheck;

	// Use this for initialization
	void Start () {

		timeCheck = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

		timeCheck += Time.deltaTime;

		if (timeCheck > 7.5f) {
			Application.LoadLevel("main_menu");
		}
	
	}
}

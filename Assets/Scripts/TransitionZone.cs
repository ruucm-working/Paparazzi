using UnityEngine;
using System.Collections;

public class TransitionZone : MonoBehaviour {

	static int sceneNum = 1;

//	private GameManager gameManager;

	void Awake(){
//		gameManager = GameObject.Find("gameManager").GetComponent<GameManager> ();
	}

	void OnTriggerEnter2D(Collider2D coll) {
			if(coll.gameObject.tag == "Player"){
				Destroy (coll.gameObject);

			sceneNum +=1;
//				gameManager.OnPlayerKilled();

			Application.LoadLevel ("scene"+sceneNum);
			Debug.Log ("Trasition to SceneNum : "+sceneNum);
		}
	}
}

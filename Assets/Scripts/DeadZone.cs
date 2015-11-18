using UnityEngine;
using System.Collections;

public class DeadZone : MonoBehaviour {

//	private GameManager gameManager;

	void Awake(){
//		gameManager = GameObject.Find("gameManager").GetComponent<GameManager> ();
	}

	void OnTriggerExit2D(Collider2D coll) {
			if(coll.gameObject.tag == "Player"){
				Destroy (coll.gameObject);
//				gameManager.OnPlayerKilled();

			Application.LoadLevel ("scene2");
		}
	}
}

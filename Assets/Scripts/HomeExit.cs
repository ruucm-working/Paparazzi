using UnityEngine;
using System.Collections;

public class HomeExit : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown() {
		Application.LoadLevel("scene1_HomeOutside");
	}
}

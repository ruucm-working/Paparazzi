using UnityEngine;
using System.Collections;

public class CharacterJump : MonoBehaviour {



	public float jumpSpeed = 10f;
	private Rigidbody2D body2d;
	private InputState inputState;

	// Use this for initialization
	void Start () {
	
		body2d = GetComponent<Rigidbody2D> ();
		inputState = GetComponent<InputState> ();
	}
	
	// Update is called once per frame
	void Update () {


		Debug.Log ("inputState.actionButton : "+inputState.actionButton);
//		if (inputState.actionButton && inputState.standing)
		if (inputState.actionButton)
			body2d.velocity = new Vector2 (0,jumpSpeed);
	
	}
}

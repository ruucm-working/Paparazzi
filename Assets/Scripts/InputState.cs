using UnityEngine;
using System.Collections;

public class InputState : MonoBehaviour {



	public bool actionButton;
	public float absVelX = 0f;
	public float absVelY = 0f;
	public bool standing;
	public float standingThreshold = 1;

	private Rigidbody2D body2d;




	// Use this for initialization
	void Start () {
		body2d = GetComponent<Rigidbody2D> ();


	}
	
	// Update is called once per frame
	void Update () {

		actionButton = Input.anyKeyDown;
	
	}


	void FixedUpdate(){

		//Debug.Log("FixedUpdate");

		//body2d.velocity = new Vector2 (0,5f);
	

		absVelX = System.Math.Abs (body2d.velocity.x);
		absVelY = System.Math.Abs (body2d.velocity.y);

		//Debug.Log("body2d.velocity.y : "+body2d.velocity.y);


		standing = absVelY <= standingThreshold;

	}


	//void FixedUpdate() {
	//	body2d.AddForce(Vector2.up);
	//}


}

using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour {
	
	
	public Vector2 velocity =Vector2.zero; //(0,0)
	
	//moving itself
	private Rigidbody2D body2d;
	
	void Awake(){
		
		body2d = GetComponent<Rigidbody2D> ();
		
		
	}
	
	
	// Update is called once per frame
	void Update () {
		
		body2d.velocity = velocity;
		
	}
}

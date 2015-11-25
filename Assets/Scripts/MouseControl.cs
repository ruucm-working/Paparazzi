using UnityEngine;
using System.Collections;

public class MouseControl : MonoBehaviour {
	
	public float speed = 1.5f;
	private Vector3 target;
	public float dist = 0.1f;
	public Animator anim;


	void Start () {
		target = transform.position;
	}
	
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			target.z = transform.position.z;

			anim.SetBool("Move",true);
		}
		Vector3 dest = target - transform.position;
		if (dest.magnitude < dist) {
			anim.SetBool("Move", false);
		}
//		else
		transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
	}    
}
using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public static NewBehaviourScript Instance;

	public bool a1 = false;


	void Awake()
	{
		Instance = this;
		DontDestroyOnLoad (Instance);

//		NewBehaviourScript.Instance
	}

}

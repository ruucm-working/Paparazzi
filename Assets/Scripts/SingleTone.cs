using UnityEngine;
using System.Collections;

public class SingleTone : MonoBehaviour {
	public static SingleTone Instance;

	public bool a1 = false;

	public bool[] TakeShot = new bool[10];


	void Awake()
	{
		Instance = this;
		DontDestroyOnLoad (Instance);

		for(int i=0 ; i<10 ;i++){


			TakeShot[i] = false;


		}

//		NewBehaviourScript.Instance
	}

}

using UnityEngine;
using System.Collections;

public class DataStatus : MonoBehaviour {

	public static bool redFilm;
	public static bool blueFilm;
	public static bool orangeFilm;
	public static bool pupleFilm;
	public static bool pinkFilm;

	void Awake()
	{
		DontDestroyOnLoad (this); 
	}

	// Use this for initialization
	void Start () {

		redFilm = false;
		blueFilm = false;
		orangeFilm = false;
		pupleFilm = false;
		pinkFilm = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (redFilm == true && blueFilm == true && orangeFilm == true
			&& pupleFilm == true && pinkFilm == true) {
			Application.LoadLevel("ending");
		}
	
	}
}

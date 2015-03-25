using UnityEngine;
using System.Collections;

public class StartGame_Control : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
	}


	// Update is called once per frame
	void Update () 
	{
//		if (Input.touchCount > 0)
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Application.LoadLevel("PlayGame");
		}
	}
}

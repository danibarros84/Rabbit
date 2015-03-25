using UnityEngine;
using System.Collections;

public class Caixa_Behaviour : MonoBehaviour 
{
	public float speed;
	public GameObject caixa;
	private Player_Control Player_Control;
	private bool passou;

	
	// Use this for initialization
	void Start () 
	{
		Player_Control = FindObjectOfType (typeof(Player_Control)) as Player_Control;
	}


	void OnEnable()
	{
		passou = false;
	}


	// Update is called once per frame
	void Update () 
	{
		transform.position += new Vector3 (speed, 0, 0) * Time.deltaTime;

		if (transform.position.x < Player_Control.transform.position.x && !passou) 
		{
			Player_Control.Addscore();
			passou = true;
		}

		if (transform.position.x < -7.5f) 
		{
			caixa.SetActive(false);
		}
	}
}

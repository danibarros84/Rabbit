using UnityEngine;
using System.Collections;

public class Player_Control : MonoBehaviour 
{
	public Transform player;
	public float jumpForce;
	public bool isjumped;
	public float jumpTime;
	public float jumpDelay;
	private Animator anim;
	int score = 0;


	// Use this for initialization
	void Start () 
	{
		anim = player.GetComponent<Animator> ();
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		Jump ();
	}


	void Jump ()
	{
//		if (Input.touchCount > 0 && !isjumped) 
		if (Input.GetKeyDown(KeyCode.Space) && !isjumped) 
		{	
			rigidbody2D.AddForce(transform.up * jumpForce);
			anim.SetTrigger ("jump");
			jumpTime = jumpDelay;
			isjumped = true;
		} 

		jumpTime -= Time.fixedDeltaTime;

		if (jumpTime <= 0 && isjumped)
		{
			anim.SetTrigger ("run");
			isjumped = false;
		}
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		Application.LoadLevel ("GameOver");
	}


	public void Addscore ()
	{
		score++;
	}


	void OnGUI()
	{
		GUI.color = Color.black;
		GUILayout.Label (" Score: " + score.ToString ());
	}
}

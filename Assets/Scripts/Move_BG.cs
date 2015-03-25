using UnityEngine;
using System.Collections;

public class Move_BG : MonoBehaviour 
{
	public float speed;
	private Material currentMaterial;
	private float offset;


	// Use this for initialization
	void Start () 
	{
		currentMaterial = renderer.material;
	}


	// Update is called once per frame
	void Update () 
	{
		offset += 0.001f;
		currentMaterial.SetTextureOffset ("_MainTex", new Vector2 (offset*speed,0 ));
	}
}

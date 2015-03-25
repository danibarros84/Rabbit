using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn_Caixa : MonoBehaviour 
{
	public float maxHeigth;
	public float minHeigth;
	public float rateSapwn;
	public int maxCaixa;
	public GameObject prefab;
	public List<GameObject> caixa;
	private float currentRateSapwn;
	private float randPosition;


	// Use this for initialization
	void Start () 
	{
		for (int i=0; i < maxCaixa; i++) 
		{
			GameObject tempCaixa = Instantiate(prefab) as GameObject;
			caixa.Add(tempCaixa);
			tempCaixa.SetActive(false);
		}
	}


	// Update is called once per frame
	void Update () 
	{
		currentRateSapwn += Time.deltaTime;
		
		if (currentRateSapwn > rateSapwn) 
		{
			currentRateSapwn = 0;
			Spawn();
		}
	}


	private void Spawn()
	{
		int rand = Random.Range (0, 9);// gera numeros inteiros de forma ramdomica usando o range de 0 a 9
		
		if (rand < 5) 
		{
			randPosition = minHeigth;
		} 
		else 
		{
			randPosition = maxHeigth;
		}

		GameObject tempCaixa = null;
		
		for (int i=0; i < maxCaixa; i++) 
		{
			if(caixa[i].activeSelf == false)
			{
				tempCaixa = caixa[i];
				break;
			}
		}
		
		if (tempCaixa != null) 
		{
			tempCaixa.transform.position = new Vector3(transform.position.x,randPosition,transform.position.z);
			tempCaixa.SetActive(true);
		}
	}
}

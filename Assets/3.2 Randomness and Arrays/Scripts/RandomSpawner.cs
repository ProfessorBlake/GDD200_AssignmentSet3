	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
	public GameObject[] PrefabArray; //Arrays are a "list" of elements. The first element always starts at position 0 and have a fixed length.

	private void Start()
	{
		float r = Random.value; //Random.value will return a float between 0.0 - 1.0

		Debug.Log(r);

		if(r > 0.5f)
		{
			Debug.Log("Heads");
		}
		else
		{
			Debug.Log("Tails");
		}
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			Instantiate(PrefabArray[0], new Vector3(-4f, 4f), Quaternion.identity);
		}
		else if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			Instantiate(PrefabArray[1], new Vector3(4f, 4f), Quaternion.identity);
		}
		else if (Input.GetKeyDown(KeyCode.Space)) //Choose a random prefab
		{
			int r = Random.Range(0, PrefabArray.Length);
			Debug.Log(PrefabArray[r].name);
			Instantiate( PrefabArray[r], new Vector3(0f, 4f), Quaternion.identity);
		}
	}
}

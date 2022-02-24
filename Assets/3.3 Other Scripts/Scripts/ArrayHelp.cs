using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayHelp : MonoBehaviour
{
    public GameObject[] myArr;

	private void Start()
	{
		
	}

	private void Update()
	{
		if (Input.GetMouseButton(0))
		{
			GameObject newBall = Instantiate(myArr[0], new Vector3(0f, 0f, 0f), Quaternion.identity);

			newBall.GetComponent<SpriteRenderer>().color = Color.yellow;
		}
	}
}

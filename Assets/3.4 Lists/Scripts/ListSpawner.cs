using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListSpawner : MonoBehaviour
{
	public GameObject BallPrefab;
	public List<GameObject> BallList;

	private void Start()
	{
		BallList = new List<GameObject>(); //Remember to initialize a list or you will get an error when trying to add to it.
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject newBall = Instantiate(BallPrefab, new Vector3(Random.Range(-5f, 5f), 5f, 0f), Quaternion.identity);
			BallList.Add(newBall);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			int[] numbers = new int[4] { 1, 2, 3, 4 };
			foreach(int n in numbers)
			{
				Debug.Log(n);
			}

			foreach(GameObject ball in BallList)
			{
				Destroy(ball);
			}
			BallList.Clear();
		}
		else if(Input.GetKeyDown(KeyCode.Space))
		{
			foreach(GameObject ball in BallList)
			{
				ball.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-20f, 20f), Random.Range(10f, 20f));
			}
		}
	}
}

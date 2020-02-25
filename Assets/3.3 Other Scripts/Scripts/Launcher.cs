using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
	public GameObject BallPrefab;
	public string[] MessageArr;
	public float Power;

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			GameObject newGameObj = Instantiate(BallPrefab, transform.position, Quaternion.identity);

			Ball newBall = newGameObj.GetComponent<Ball>();
			newBall.Launch(transform.up * Power * Random.Range(0.75f, 1.25f), MessageArr[Random.Range(0, MessageArr.Length)]);
		}
	}
}

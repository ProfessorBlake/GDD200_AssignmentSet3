using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
	public float Speed;

	private void Update()
	{
		transform.position += new Vector3(0f, -Speed, 0f) * Time.deltaTime;

		if(transform.position.y < -6f)
		{
			Score.TotalPoints += 1;
			transform.position = new Vector3(Random.Range(-2f, 2f), 7f, 0f);
			Time.timeScale = Random.Range(0.2f, 2.5f);
		}
	}
}

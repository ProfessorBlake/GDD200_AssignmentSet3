using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
	public TMP_Text Text;

	private float ourTime = 0f;

	private void Update()
	{
		ourTime += Time.deltaTime;

		Text.text = "Score: " + Score.TotalPoints +
			"\nTime Scale: " + Time.timeScale +
			"\nTime Elapsed: " + Time.unscaledTime +
			"\nTime: " + ourTime;
	}
}
